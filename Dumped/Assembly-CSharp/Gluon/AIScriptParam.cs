/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class AIScriptParam
	{
		// Fields
		public Column[] columns;
	
		// Properties
		public string ValueString { get; }
		public AIScriptValue Value { get; }
		public bool IsValueString { get; }
	
		// Nested types
		[Serializable]
		public class Column
		{
			// Fields
			public AIScriptValue[] values;
			public TermsCompare.eCompare compare;
	
			// Constructors
			public Column();
		}
	
		// Constructors
		public AIScriptParam();
	}
}
