/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class WalkArrow : FastUpdateMonoBehaviour
	{
		// Fields
		public NextArrow targetNextAllow;
		private Vector3 defaultScale;
		private bool hit;
		private const string effectName = "EFF_DUN_ETC_001_001";
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__5 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WalkArrow __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__5(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _Walk_d__7 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlayerCtrl player;
			public WalkArrow __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Walk_d__7(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public WalkArrow();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnTriggerStay(Collider other);
		[IteratorStateMachine]
		private IEnumerator Walk(PlayerCtrl player);
	}
}
