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
	public class AIScriptValue
	{
		// Fields
		public string valString;
		public int valInt;
		public float valFloat;
		public ValueType valType;
		public string[] splitValStrings;
	
		// Properties
		public ValueType Type { get; }
	
		// Nested types
		public enum ValueType
		{
			String = 0,
			Int = 1,
			Float = 2
		}
	
		// Constructors
		public AIScriptValue(string str);
		public AIScriptValue(int val);
		public AIScriptValue(float val);
	
		// Methods
		public void SetValue(string str, bool isParser = false);
		public void SetValue(int val);
		public void SetValue(float val);
		public void SetValue(AIScriptValue value);
		public void AddValue(AIScriptValue value);
		public void SubValue(AIScriptValue value);
		public void MulValue(AIScriptValue value);
		public override string ToString();
	}
}
