using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpVarArg : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.VarArg && instruction.B != 0;

		public override string GetObfuscated(ObfuscationContext context) =>
			"local A=Inst[OP_A];local B=Inst[OP_B];for Idx=A,B do Stk[Idx]=Vararg[Idx-A];end;";

		public override void Mutate(Instruction instruction)
		{
			instruction.B += instruction.A - 1;
		}
	}
	
	public class OpVarArgB0 : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.VarArg && instruction.B == 0;

		public override string GetObfuscated(ObfuscationContext context) =>
			"local A=Inst[OP_A];Top=A+Varargsz-1;for Idx=A,Top do local VA=Vararg[Idx-A];Stk[Idx]=VA;end;";
	}
}