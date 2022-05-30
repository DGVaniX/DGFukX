using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpLoadNil : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.LoadNil;
		
		public override string GetObfuscated(ObfuscationContext context) =>
			"for Idx=Inst[OP_A],Inst[OP_B] do Stk[Idx]=nil;end;";
	}
}