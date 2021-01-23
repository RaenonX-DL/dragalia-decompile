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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class ProximityObject : FastUpdateMonoBehaviour
	{
		// Fields
		[Lock]
		[SerializeField]
		private string ActionSE;
		[Lock]
		[SerializeField]
		private string ActionEffect;
		private Animator anim;
		private int idle;
		private int warming;
		private bool hasWarming;
		private float speed;
		private float endTime;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _PlaySEAndEffect_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ProximityObject __4__this;
			public CharacterBase chara;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySEAndEffect_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ProximityObject();
	
		// Methods
		private void Start();
		public override void FastUpdate();
		private void OnTriggerEnter(Collider other);
		[IteratorStateMachine]
		private IEnumerator PlaySEAndEffect(CharacterBase chara);
	}
}
