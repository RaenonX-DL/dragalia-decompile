using System.Runtime.InteropServices;

namespace MsgPack.Compiler
{
	[StructLayout(3, Size = 4)]
	public enum VariableType
	{
		Local,
		Arg
	}
}
