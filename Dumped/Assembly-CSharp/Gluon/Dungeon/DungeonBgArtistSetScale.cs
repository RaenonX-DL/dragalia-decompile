/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonBgArtistSetScale : DungeonBgArtistBase
	{
		// Fields
		[SerializeField]
		private CalcKind calcKind;
		[SerializeField]
		private Vector3 baseLocalScale;
		[Range]
		[SerializeField]
		private float curveCycleSecond;
		public AnimationCurve animationCurve;
		[Range]
		[SerializeField]
		private float curveCycleOffset;
		[SerializeField]
		private bool clampZeroFlag;
	
		// Nested types
		public enum CalcKind
		{
			Set = 0,
			Add = 1
		}
	
		[CompilerGenerated]
		private sealed class _UpdateOffset_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DungeonBgArtistSetScale __4__this;
			private Vector3 _scaleOrigin_5__2;
			private float _progressSec_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateOffset_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DungeonBgArtistSetScale();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator UpdateOffset();
	}
}
