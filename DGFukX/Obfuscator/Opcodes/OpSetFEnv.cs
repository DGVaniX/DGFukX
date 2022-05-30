using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpSetFEnv : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.SetFenv;

		public override string GetObfuscated(ObfuscationContext context) =>
			"Env = Stk[Inst[OP_A]]";
	}
}