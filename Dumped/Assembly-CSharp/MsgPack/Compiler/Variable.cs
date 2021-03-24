/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MsgPack.Compiler
{
	public class Variable
	{
		// Fields
		[CompilerGenerated]
		private VariableType _VarType_k__BackingField;
		[CompilerGenerated]
		private int _Index_k__BackingField;
	
		// Properties
		public VariableType VarType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int Index { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		private Variable(VariableType type, int index);
	
		// Methods
		public static Variable CreateLocal(LocalBuilder local);
		public static Variable CreateArg(int idx);
	}
}
