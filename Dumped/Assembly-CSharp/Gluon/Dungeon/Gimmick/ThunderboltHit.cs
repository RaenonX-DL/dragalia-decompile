/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class ThunderboltHit : GimmickBase
	{
		// Fields
		protected EffectObject effect;
		public GimmickThunderboltElement variation;
		private CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private SphereCollider hitCollider;
		private const float hitTime = 0.2f;
		private float maxRange;
		[CompilerGenerated]
		private bool _isAction_k__BackingField;
	
		// Properties
		public bool isAction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Action_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ThunderboltHit __4__this;
			public float intervalSec;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Action_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ThunderboltHit();
	
		// Methods
		private void Start();
		public void StartAction(float intervalSec);
		[IteratorStateMachine]
		private IEnumerator Action(float intervalSec);
		private void OnTriggerEnter(Collider other);
	}
}
