namespace DGFukX.Obfuscator
{
	public class ObfuscationSettings
	{
		public bool EncryptStrings;
		public bool EncryptImportantStrings;
		public bool ControlFlow;
		public bool BytecodeCompress;
		public int DecryptTableLen;
		public bool PreserveLineInfo;
		public bool Mutate;
		public bool SuperOperators;
		public int MaxMiniSuperOperators;
		public int MaxMegaSuperOperators;
		public int MaxMutations;		

		public ObfuscationSettings(bool encryptStrings, bool encryptImpStrings, bool ctrlFlow, bool bcCompress, int decTableLen, bool presLineInfo, bool muts, bool supOps, int megaSupOps, int miniSupOps, int maxMuts)
		{
			EncryptStrings = encryptStrings;
			EncryptImportantStrings = encryptImpStrings;
			ControlFlow = ctrlFlow;
			BytecodeCompress = bcCompress;
			DecryptTableLen = decTableLen;
			PreserveLineInfo = presLineInfo;
			Mutate = muts;
			SuperOperators = supOps;
			MaxMegaSuperOperators = megaSupOps;
			MaxMiniSuperOperators = miniSupOps;
			MaxMutations = maxMuts;
		}
	}
}