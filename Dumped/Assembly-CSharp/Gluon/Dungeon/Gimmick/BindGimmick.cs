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
	public class BindGimmick : GimmickBase
	{
		// Fields
		[Lock]
		[SerializeField]
		private string effectLabelGimmick;
		[Lock]
		[SerializeField]
		private string effectLabelBind;
		[Lock]
		[SerializeField]
		private string soundLabelCatch1;
		[Lock]
		[SerializeField]
		private string soundLabelCatch2;
		[Lock]
		[SerializeField]
		private string soundLabelRelease;
		private EffectObject effectObj;
		private SphereCollider hitCollider;
		private bool eventInitializedFlag;
		[Lock]
		[SerializeField]
		private float checkRadiusIdle;
		[Lock]
		[SerializeField]
		private float checkRadiusCatch;
		[Lock]
		[SerializeField]
		private float colliderRadius;
		[Lock]
		[SerializeField]
		private float waitSecIdleDelay;
		[Lock]
		[SerializeField]
		private float waitSecCatchDelay;
		[Lock]
		[SerializeField]
		private float waitSecCatchLoop;
		[Lock]
		[SerializeField]
		private float waitSecReleased;
		private static readonly int effectTriggerIdle;
		private static readonly int effectTriggerCatch;
		private static readonly int effectTriggerRelease;
		private CtrlBindGimmick _ctrlBind;
		private long _nextBindEventId;
		private long _recvFireBindEventId;
		private List<CharacterBase> targetCharaList;
		private State _state;
	
		// Nested types
		public enum State
		{
			ActionRunning = 0,
			Waiting = 1
		}
	
		[CompilerGenerated]
		private sealed class _StartAction_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BindGimmick __4__this;
			public float delay;
			public long bindEventId;
			private float _waitSec_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BindGimmick();
		static BindGimmick();
	
		// Methods
		protected override void Awake();
		public override void FastUpdate();
		[IteratorStateMachine]
		private IEnumerator StartAction(long bindEventId, float delay);
		private void PlaySound(string soundLabel);
		private bool CheckNearChara(float radius, List<CharacterBase> retList);
		private void OnActionEnd();
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public override void OnDisconnected();
		private void SetBind(long bindEventId);
		private bool IsAbortRequest();
		public void SendCtrlBindEvent(long bindEventId, BindEvent ctrlBindData);
	}
}
