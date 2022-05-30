using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpConcat : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.Concat;

		public override string GetObfuscated(ObfuscationContext context) =>
			"local B=Inst[OP_B];local K=Stk[B] for Idx=B+1,Inst[OP_C] do K=K..Stk[Idx];end;Stk[Inst[OP_A]]=K;";
	}
}