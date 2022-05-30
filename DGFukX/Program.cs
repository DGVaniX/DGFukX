using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;
using DGFukX.Extensions;
using DGFukX.Obfuscator;
using DGFukX.Obfuscator.Control_Flow;
using DGFukX.Obfuscator.Encryption;
using DGFukX.Obfuscator.VM_Generation;

namespace DGFukX
{
    public static class DGX
	{
		public static Random Random = new Random();
		private static Encoding _fuckingLua = Encoding.GetEncoding(28591);

		public static string obfuscationLogs;
        public static DateTime now = DateTime.Now;

        private static readonly string luacPath = AppDomain.CurrentDomain.BaseDirectory + @"Luac\luac.exe";
		private static readonly string luajitPath = AppDomain.CurrentDomain.BaseDirectory + @"Luac\luajit.exe";

		public static void AddObfuscationLog(string text)
        {
			now = DateTime.Now;

			obfuscationLogs += "[" + now.Hour + ":" + now.Minute + ":" + now.Second + ":" + now.Millisecond + "] " + text + "\r\n";
		}

		public static bool Obfuscate(string path, string input, ObfuscationSettings settings, out string error)
		{
			try
			{
				obfuscationLogs = "";
				error = "";

				path = AppDomain.CurrentDomain.BaseDirectory + path;
				
				string l = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Luac\", "luac.out");

				if (!File.Exists(input))
					throw new Exception("Invalid input file.");

				AddObfuscationLog("Checking file...");

				Process proc = new Process
				{
					StartInfo =
					{
						FileName  = luacPath,
						Arguments = "-o \"" + l + "\" \"" + input + "\"",
						UseShellExecute = false,
						RedirectStandardError = true,
						RedirectStandardOutput = true
					}
				};

				string err = "";
				
				proc.OutputDataReceived += (sender, args) => { err += args.Data; };
				proc.ErrorDataReceived += (sender, args) => { err += args.Data; };

				AddObfuscationLog("Processing Luac...");

				proc.Start();
				proc.BeginOutputReadLine();
				proc.BeginErrorReadLine();
				proc.WaitForExit();

				if (err != "") {
					AddObfuscationLog(err);
				}

				if (!File.Exists(l))
					return false;
				
				File.Delete(l);
				string t0 = Path.Combine(path, "t0.lua");

				AddObfuscationLog("Stripping comments...");

				proc = new Process
				{
					StartInfo =
					{
						FileName = luajitPath,
						Arguments =
							AppDomain.CurrentDomain.BaseDirectory + @"Lua\Minifier\luasrcdiet.lua --noopt-whitespace --noopt-emptylines --noopt-numbers --noopt-locals --noopt-strings --opt-comments " + "\"" +
							input + "\" -o \"" + t0 + "\"",
							UseShellExecute        = false,
							RedirectStandardError  = true,
							RedirectStandardOutput = true
					}
				};

				proc.OutputDataReceived += (sender, args) => { err += args.Data; };
				proc.ErrorDataReceived  += (sender, args) => { err += args.Data; };

				proc.Start();
				proc.BeginOutputReadLine();
				proc.BeginErrorReadLine();
				proc.WaitForExit();

				error = err;

				if (err != "")
				{
					AddObfuscationLog(err);
				}

				if (!File.Exists(t0))
				{
					return false;
				}

				string t1 = Path.Combine(path, "t1.lua");

				AddObfuscationLog("Compiling script...");

				File.WriteAllText(t1, new ConstantEncryption(settings, File.ReadAllText(t0, _fuckingLua)).EncryptStrings());
				proc = new Process
				{
					StartInfo =
					{
						FileName  = luacPath,
						Arguments = "-o \"" + l + "\" \"" + t1 + "\"",
						UseShellExecute = false,
						RedirectStandardError = true,
						RedirectStandardOutput = true
					}
				};

				proc.OutputDataReceived += (sender, args) => { err += args.Data; };
				proc.ErrorDataReceived += (sender, args) => { err += args.Data; };

				proc.Start();
				proc.BeginOutputReadLine();
				proc.BeginErrorReadLine();
				proc.WaitForExit();

				error = err;
				if (err != "")
				{
					AddObfuscationLog(err);
				}

				if (!File.Exists(l))
				{
					return false;
				}

				AddObfuscationLog("Obfuscating script...");

				Deserializer des    = new Deserializer(File.ReadAllBytes(l));
				Chunk lChunk = des.DecodeFile();

				if (settings.ControlFlow)
				{
					CFContext cf = new CFContext(lChunk);
					cf.DoChunks();
				}

				AddObfuscationLog("Serializing script...");

				//shuffle stuff
				//lChunk.Constants.Shuffle();
				//lChunk.Functions.Shuffle();

				ObfuscationContext context = new ObfuscationContext(lChunk);

				string t2 = Path.Combine(path, "t2.lua");
				string c = new Generator(context).GenerateVM(settings);

				//string byteLocal = c.Substring(null, "\n");
				//string rest = c.Substring("\n");

				File.WriteAllText(t2, c, _fuckingLua);

				string t3 = Path.Combine(path, "t3.lua");

				AddObfuscationLog("Minifying script...");

				proc = new Process
				{
					StartInfo =
					{
						FileName = luajitPath,
						Arguments =
							AppDomain.CurrentDomain.BaseDirectory + @"Lua\Minifier\luasrcdiet.lua --maximum --opt-entropy --opt-emptylines --opt-eols --opt-numbers --opt-whitespace --opt-locals --noopt-strings " + 
							"\"" + t2 + "\" -o \"" + t3 + "\"",
					}
				};

				proc.Start();
				proc.WaitForExit();

				if (!File.Exists(t3))
				{
					return false;
				}

				AddObfuscationLog("Adding Watermark [#Valoare]...");

				File.WriteAllText(Path.Combine(path, "out.lua"), File.ReadAllText(t3, _fuckingLua)
					/*.Replace("\n", "--[[DG]]")
					.Replace("\r", "--[[DG]]")
					.Replace("\r\n", "--[[DG]]")
					.Replace(" ", "--[[DG]]")
					.Replace("	", "--[[DG]]") */ + @"

--[[S][U][G][E][T][I][-][P][U][L][A]

			███╗ ██╗ ██╗ ██╗   ██╗ █████╗ ██╗      ██████╗  █████╗ ██████╗ ███████╗███╗
			██╔╝████████╗██║   ██║██╔══██╗██║     ██╔═══██╗██╔══██╗██╔══██╗██╔════╝╚██║
			██║ ╚██╔═██╔╝██║   ██║███████║██║     ██║   ██║███████║██████╔╝█████╗   ██║
			██║ ████████╗╚██╗ ██╔╝██╔══██║██║     ██║   ██║██╔══██║██╔══██╗██╔══╝   ██║
			███╗╚██╔═██╔╝ ╚████╔╝ ██║  ██║███████╗╚██████╔╝██║  ██║██║  ██║███████╗███║
			╚══╝ ╚═╝ ╚═╝   ╚═══╝  ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══╝
										DGVaniX[#Valoare]

					  PENTRU TOTI RATATII CARE INCEARCA SA IMI FURE MUNCA!
	
				NU VA MAI DATI SCRIPTERI, NU VA MAI DATI SMECHERI CA NU VA MERGE CU MINE!
				PUTETI SA IMI LUATI SERVERUL DE 100 DE ORI, CA EU NU MA LAS, GASESC METODE
				SI IL REFAC MAI BUN DECAT ERA INAINTE, ASTA DATORITA VOUA, FOMISTILOR
				CARE MURITI DE CIUDA CA NU PUTETI AJUNGE LA VALOAREA MEA ;)
	
	 #####     #       #     #    #       ######     #    #     #    #          #       #     # #     # ### ####### 
	#     #   # #      #     #   # #      #     #   # #   #     #    #         # #      ##   ## #     #  #  #       
	#        #   #     #     #  #   #     #     #  #   #  #     #    #        #   #     # # # # #     #  #  #       
	 #####  #     #    #     # #     #    #     # #     # #     #    #       #     #    #  #  # #     #  #  #####   
		  # #######     #   #  #######    #     # ####### #     #    #       #######    #     # #     #  #  #       
	#     # #     #      # #   #     #    #     # #     # #     #    #       #     #    #     # #     #  #  #       
	 #####  #     #       #    #     #    ######  #     #  #####     ####### #     #    #     #  #####  ### ####### 

[D][G][V][A][N][I][X][-][#][V][A][L][O][A][R][E]]", _fuckingLua);

				AddObfuscationLog("SCRIPTUL A FOST OBFUSCAT!");

				return true;
			}
			catch (Exception e)
			{
				AddObfuscationLog("A APARUT O EROARE!");
				AddObfuscationLog(e.ToString());

				error = e.ToString();
				return false;
			}
		}
	}
}