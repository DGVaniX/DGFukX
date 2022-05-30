using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
	public class OpTForLoop : VOpcode
	{
		public override bool IsInstruction(Instruction instruction) =>
			instruction.OpCode == Opcode.TForLoop;

		public override string GetObfuscated(ObfuscationContext context) =>
			@"
local A = Inst[OP_A];
local C = Inst[OP_C];
local CB = A + 2
local Result = {Stk[A](Stk[A + 1],Stk[CB])};
for Idx = 1, C do 
	Stk[CB + C] = Result[Idx];
end;
local R = Stk[A+3];
if R then 
	Stk[CB] = R 
	InstrPoint = Inst[OP_B];
else
	InstrPoint = InstrPoint + 1;
end;";
		
		public override void Mutate(Instruction instruction)
		{
			instruction.B = instruction.PC + instruction.Chunk.Instructions[instruction.PC + 1].B + 2;
			instruction.InstructionType = InstructionType.AsBxC;
		}
	}
}