/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack.Compiler
{
	internal static class PackILGenerator
	{
		// Methods
		public static void EmitPackCode(Type type, MethodInfo mi, ILGenerator il, Func<Type, MemberInfo[]> targetMemberSelector, Func<MemberInfo, string> memberNameFormatter, Func<Type, MethodInfo> lookupPackMethod);
		private static void EmitPackArrayCode(MethodInfo mi, ILGenerator il, Type t, Variable var_writer, Variable var_obj, Variable var_loop, Func<Type, MethodInfo> lookupPackMethod);
		private static void EmitPackMemberValueCode(Type type, ILGenerator il, Variable var_writer, Variable var_obj, MemberInfo m, Variable elementIdx, Type currentType, MethodInfo currentMethod, Func<Type, MethodInfo> lookupPackMethod);
		public static void EmitUnpackCode(Type type, MethodInfo mi, ILGenerator il, Func<Type, MemberInfo[]> targetMemberSelector, Func<MemberInfo, string> memberNameFormatter, Func<Type, MethodInfo> lookupUnpackMethod, Func<Type, IDictionary<string, int>> lookupMemberMapping, MethodInfo lookupMemberMappingMethod);
		private static void EmitUnpackMapCode(Type type, MethodInfo mi, ILGenerator il, Func<Type, MemberInfo[]> targetMemberSelector, Func<MemberInfo, string> memberNameFormatter, Func<Type, MethodInfo> lookupUnpackMethod, Func<Type, IDictionary<string, int>> lookupMemberMapping, MethodInfo lookupMemberMappingMethod);
		private static void EmitUnpackArrayCode(Type arrayType, MethodInfo mi, ILGenerator il, Func<Type, MemberInfo[]> targetMemberSelector, Func<MemberInfo, string> memberNameFormatter, Func<Type, MethodInfo> lookupUnpackMethod);
		private static void EmitUnpackReadAndTypeCheckCode(ILGenerator il, Variable msgpackReader, MethodInfo typeCheckMethod, MethodInfo failedMethod, bool nullCheckAndReturn);
		internal static void UnpackFailed();
	
		// Extension methods
		private static Type GetMemberType(this MemberInfo mi);
	}
}
