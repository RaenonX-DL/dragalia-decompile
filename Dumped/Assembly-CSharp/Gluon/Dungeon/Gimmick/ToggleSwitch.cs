/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class ToggleSwitch : DungeonObjectBase
	{
		// Fields
		[HideInInspector]
		public ToggleSwitchColor color;
		public float effectLoopPositionY;
		public float effectHitPositionY;
		public float effectDelayTime;
		private bool hitted;
		private GameObject blue;
		private Animator blueAnimator;
		private GameObject red;
		private Animator redAnimator;
		[SerializeField]
		private ToggleDoor[] door;
		private EffectObject effectLoop;
		private Vector3 effectPosition;
		private EffectObject effectUnderLoop;
		private static readonly string[] effectName;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ToggleAnimation_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ToggleSwitch __4__this;
			private GameObject _offObject_5__2;
			private Animator _offAnimator_5__3;
			private GameObject _onObject_5__4;
			private Animator _onAnimator_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ToggleAnimation_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ToggleSwitch();
		static ToggleSwitch();
	
		// Methods
		protected override void Awake();
		private string GetRedName();
		private void ToggleColor();
		public override void OnCollided(GameObject target, CollisionHitAttribute data);
		private EffectObject PlayEffect(int index, Vector3 pos, Quaternion rot);
		[IteratorStateMachine]
		private IEnumerator ToggleAnimation();
		private void OnCollided(GameObject target, bool fromEvent);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
