using System.Collections.Generic;
using System.Linq;
using DGFukX.Bytecode_Library.IR;

namespace DGFukX.Obfuscator.Control_Flow.Blocks
{
	public class Block
	{
		public Chunk Chunk;
		public List<Instruction> Body = new List<Instruction>();
		public Block Successor = null;

		public Block(Chunk c) =>
			Chunk = c;
	}
}