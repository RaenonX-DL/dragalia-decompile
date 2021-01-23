/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack.Compiler
{
	public static class EmitExtensions
	{
		// Extension methods
		public static void EmitLd(this ILGenerator il, Variable v);
		public static void EmitLd(this ILGenerator il, params Variable[] list);
		public static void EmitLdarg(this ILGenerator il, Variable v);
		public static void EmitLdloc(this ILGenerator il, Variable v);
		public static void EmitSt(this ILGenerator il, Variable v);
		public static void EmitStarg(this ILGenerator il, Variable v);
		public static void EmitStloc(this ILGenerator il, Variable v);
		public static void EmitLdc(this ILGenerator il, int v);
		public static void EmitLd_False(this ILGenerator il);
		public static void EmitLd_True(this ILGenerator il);
		public static void EmitLdstr(this ILGenerator il, string v);
		public static void EmitLdMember(this ILGenerator il, MemberInfo m);
		public static void EmitStMember(this ILGenerator il, MemberInfo m);
	}
}
