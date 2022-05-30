using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpNewTableB0 : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) => instruction.OpCode == Opcode.NewTable;

		public override string GetObfuscated(ObfuscationContext context) =>
			"Stk[Inst[OP_A]]={};";
	}
}