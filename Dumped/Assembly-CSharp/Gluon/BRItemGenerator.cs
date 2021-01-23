/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRItemGenerator : MonoBehaviour
	{
		// Fields
		public static BRItemGenerator instance;
		private Dictionary<int, List<BRItemPopPoint>> popPointDict;
		private int totalPointCount;
		private bool isReady;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BRItemPopPoint, Guid> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal Guid _Start_b__5_0(BRItemPopPoint a);
		}
	
		// Constructors
		public BRItemGenerator();
		static BRItemGenerator();
	
		// Methods
		public static int RegisterPopPoint(BRItemPopPoint popPoint);
		private void Start();
		private void OnDestroy();
		public bool CanGenerateItems();
		public void GenerateItems();
	}
}
