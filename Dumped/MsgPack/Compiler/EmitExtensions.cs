using System.Reflection;
using System.Reflection.Emit;

namespace MsgPack.Compiler
{
	public static class EmitExtensions
	{
		public static void EmitLd(this ILGenerator il, Variable v)
		{
		}

		public static void EmitLd(this ILGenerator il, Variable[] list)
		{
		}

		public static void EmitLdarg(this ILGenerator il, Variable v)
		{
		}

		public static void EmitLdloc(this ILGenerator il, Variable v)
		{
		}

		public static void EmitSt(this ILGenerator il, Variable v)
		{
		}

		public static void EmitStarg(this ILGenerator il, Variable v)
		{
		}

		public static void EmitStloc(this ILGenerator il, Variable v)
		{
		}

		public static void EmitLdc(this ILGenerator il, int v)
		{
		}

		public static void EmitLd_False(this ILGenerator il)
		{
		}

		public static void EmitLd_True(this ILGenerator il)
		{
		}

		public static void EmitLdstr(this ILGenerator il, string v)
		{
		}

		public static void EmitLdMember(this ILGenerator il, MemberInfo m)
		{
		}

		public static void EmitStMember(this ILGenerator il, MemberInfo m)
		{
		}
	}
}
