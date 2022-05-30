using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using DGFukX;
using DGFukX.Obfuscator;

namespace DGFukX_CLI
{
	public static class Program
	{
		public static int decryptTableLength;
		public static bool bytecodeCompression;
		public static bool lineInfoPreservation;
		public static bool controlFlow;

		//String Encryption
		public static bool stringEncryption;
		public static bool impStringEncryption;

		//Super Operators
		public static bool superOperators;
		public static int maxSuperOperators;

		//Mutations
		public static bool mutations;
		public static int maxMutations;

		public static string lastFile;

		public static void SetCustomObfuscationSettings(bool encryptStrings, bool encryptImpStrings, bool ctrlFlow, bool bcCompress, int decTableLen, bool presLineInfo, bool muts, bool supOps, int megaSupOps, int miniSupOps, int maxMuts)
		{
			controlFlow = ctrlFlow;

			lineInfoPreservation = presLineInfo;

			bytecodeCompression = bcCompress;

			decryptTableLength = decTableLen;

			stringEncryption = encryptStrings;
			impStringEncryption = encryptImpStrings;

			superOperators = supOps;
			maxSuperOperators = megaSupOps;

			mutations = muts;
			maxMutations = maxMuts;
		}
		public static void OpenCompiledScriptFile(){
			new Process
			{
				StartInfo = new ProcessStartInfo(Path.GetFileNameWithoutExtension(lastFile) + ".dgx")
				{
					UseShellExecute = true
				}
			}.Start();
		}

		public static List<string> TryObfuscation(string theFile)
		{
			if (Directory.Exists("temp"))
			{
				Directory.Delete("temp", true);
				Directory.CreateDirectory("temp");
            }
            else
            {
				Directory.CreateDirectory("temp");
			}
			List<string> result = new List<string>();
			//result.Insert(1, "");
            //result.Insert(2, "");

            if (!DGX.Obfuscate("temp", theFile, new ObfuscationSettings(stringEncryption, impStringEncryption, controlFlow, bytecodeCompression, decryptTableLength, lineInfoPreservation, mutations, superOperators, maxSuperOperators, maxSuperOperators, maxMutations), out string err))
            {
				//result.Insert(2, "false")
				System.Diagnostics.Debug.WriteLine("ERR: " + err);
                return result;
            }
            else
            {
				if (File.Exists(Path.GetFileNameWithoutExtension(theFile) + ".dgx"))
				{
					File.Delete(Path.GetFileNameWithoutExtension(theFile) + ".dgx");
				}
				File.Delete("out.lua");
                File.Move("temp/out.lua", Path.GetFileNameWithoutExtension(theFile) + ".dgx");
                Directory.Delete("temp", true);

				lastFile = theFile;
				//result.Insert(2, "true");

				return result;
            }
        }
	}
}