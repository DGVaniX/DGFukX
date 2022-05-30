using DGFukX.Bytecode_Library.Bytecode;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Opcodes
{
    public class OpNewStk : VOpcode
    {
        public override bool IsInstruction(Instruction instruction) =>
            instruction.OpCode == Opcode.NewStack;

        public override string GetObfuscated(ObfuscationContext context) =>
            "Stk = {};for Idx = 0, PCount do if Idx < Params then Stk[Idx] = Args[Idx + 1]; else break end; end;";
    }
}