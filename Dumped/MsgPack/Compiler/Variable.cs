using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace MsgPack.Compiler
{
	public class Variable
	{
		public VariableType VarType
		{
			[CompilerGenerated]
			get
			{
				return default(VariableType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Index
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Variable(VariableType type, int index)
		{
		}

		public static Variable CreateLocal(LocalBuilder local)
		{
			return null;
		}

		public static Variable CreateArg(int idx)
		{
			return null;
		}
	}
}
