/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonStroke2DCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private Image dragonImage;
		[SerializeField]
		private RectTransform imageOffset;
		public Transform f2UTrans;
		public ContactAsset contactAsset;
		public const string prefabDir = "Prefabs/OutGame/UnitDetail/";
		public const string switchEffectFlashPath = "Prefabs/OutGame/UnitDetail/pf_transform_effect";
		private FlMotion switchF2u;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__7_0;
			public static Func<bool> __9__7_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__7_0();
			internal bool _Start_b__7_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DragonStroke2DCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DragonStroke2DCanvas();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void SetBgDragonImage(int dragonId, bool isEnableEffect);
		public void SwitchFlash();
	}
}
