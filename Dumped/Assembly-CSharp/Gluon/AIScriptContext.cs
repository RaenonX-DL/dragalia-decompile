/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AIScriptContext
	{
		// Fields
		public float awakeTime;
		public float hpRecode;
		public bool isCountTime;
		public float countTime;
		public float trgLength;
		public float trgHpRate;
		public bool isSearchAction;
		private Dictionary<string, AIScriptValue> _localValueDic;
	
		// Properties
		public Dictionary<string, AIScriptValue> AllLocalValueNames { get; }
	
		// Constructors
		public AIScriptContext();
	
		// Methods
		public void AddLocalValue(string name, AIScriptValue value);
		public bool ContainsLocalValue(string name);
		public AIScriptValue GetLocalValue(string name);
		public void ClearAllLocalValues();
		public void ClearAll();
		public void CopyTo(AIScriptContext context);
		public static void EncodeDeltaCompression(DeltaCompressionEncoder encoder, AIScriptContext prev, AIScriptContext next, out byte[] result);
		public static bool DecodeDeltaCompression(DeltaCompressionDecoder decoder, AIScriptContext prev, byte[] nextBinary, AIScriptContext outNext);
	}
}
