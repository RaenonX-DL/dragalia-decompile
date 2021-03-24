/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	[Serializable]
	public class FlLabelParameter
	{
		// Fields
		public string _name;
		public Vector2 _timeRange;
		public string _nextLabel;
		[NonSerialized]
		public int _Index;
		[NonSerialized]
		public int _nextIndex;
		public Hashtable _actionStartTable;
		public Hashtable _actionLoopTable;
		public Hashtable _actionEndTable;
		public Hashtable _flActionStartTable;
		public Hashtable _flActionLoopTable;
		public Hashtable _flActionEndTable;
	
		// Properties
		public string Name { get; set; }
		public Vector2 TimeRange { get; set; }
		public string NextLabel { get; set; }
		public int Index { get; set; }
		public int NextIndex { get; set; }
		public Hashtable ActionStartTable { get; set; }
		public Hashtable ActionLoopTable { get; set; }
		public Hashtable ActionEndTable { get; set; }
		public Hashtable FlActionStartTable { get; set; }
		public Hashtable FlActionLoopTable { get; set; }
		public Hashtable FlActionEndTable { get; set; }
	
		// Constructors
		public FlLabelParameter();
	
		// Methods
		public void _Initialize();
	}
}
