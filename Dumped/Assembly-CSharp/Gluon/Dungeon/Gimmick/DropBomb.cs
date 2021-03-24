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
	public class DropBomb : GimmickBase
	{
		// Fields
		public int type;
		protected EffectObject effect;
		private DungeonItemDataElement variation;
		private CollisionHitAttribute hitAttribute;
		private HashSet<int> victim;
		private SphereCollider hitCollider;
		private float hitStartTime;
		private const float hitTime = 0.2f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartAction_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropBomb __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public DropBomb();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction();
		private void OnTriggerEnter(Collider other);
	}
}
