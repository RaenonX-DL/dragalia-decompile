/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class Thunderbolt : GimmickBase
	{
		// Fields
		private GimmickThunderboltElement variation;
		private CollisionHitAttribute hitAttribute;
		private SphereCollider hitCollider;
		private bool isRange;
		private bool eventReceived;
		private float delay;
		private int randomSeed;
		private ThunderboltHit[] thunderHit;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartAction_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public Thunderbolt __4__this;
	
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
		public Thunderbolt();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction();
		protected void OnActionEnd();
		private void OnTriggerEnter(Collider other);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
