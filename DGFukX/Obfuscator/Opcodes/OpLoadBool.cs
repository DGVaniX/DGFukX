using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpLoadBool : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.LoadBool && instruction.C == 0;

		public override string GetObfuscated(ObfuscationContext context) =>
			"Stk[Inst[OP_A]]=(Inst[OP_B]~=0);";
	}
	
	public class OpLoadBoolC : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.LoadBool && instruction.C != 0;

		public override string GetObfuscated(ObfuscationContext context) =>
			"Stk[Inst[OP_A]]=(Inst[OP_B]~=0);InstrPoint=InstrPoint+1;";

		public override void Mutate(Instruction ins) =>
			ins.C = 0;
	}
}