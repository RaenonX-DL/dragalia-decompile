/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class SPFXManager
	{
		// Fields
		private static SPFXManager instance;
		private Dictionary<SPFXType, SPFXDefine> dic;
	
		// Properties
		public static SPFXManager Instance { get; }
	
		// Nested types
		public enum SPFXType
		{
			Kira = 0,
			BossDamage = 1,
			BossCrush = 2,
			PlayerDamage = 3,
			BossTail = 4,
			PlayerLocus = 5
		}
	
		public class SPFXDefine
		{
			// Fields
			public SPFXType type;
			public string spfxName;
			public int count;
			public EffectObject[] effs;
			public int currentIndex;
	
			// Constructors
			public SPFXDefine(SPFXType type, string spfxName, int count);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public SPFXManager __4__this;
			public Action onDone;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _Init_b__0();
		}
	
		// Constructors
		private SPFXManager();
		static SPFXManager();
	
		// Methods
		public static void Dispose();
		public void Init(Action onDone);
		public void Restart();
		public EffectObject Attach(Transform t, SPFXType type);
		public void OnDispose();
	}
}
