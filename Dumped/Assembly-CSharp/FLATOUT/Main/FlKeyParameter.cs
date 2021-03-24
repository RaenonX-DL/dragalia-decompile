/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlKeyParameter
	{
		// Fields
		public List<Vector2> _keyList;
		[NonSerialized]
		public int _keyCount;
	
		// Properties
		public List<Vector2> KeyList { get; set; }
	
		// Constructors
		public FlKeyParameter();
	
		// Methods
		public float _GetValue(float original, FlMotion motion, ref int startIndex);
	}
}
