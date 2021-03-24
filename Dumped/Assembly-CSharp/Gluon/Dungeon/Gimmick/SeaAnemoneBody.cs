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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class SeaAnemoneBody : GimmickBase
	{
		// Fields
		private GimmickSeaAnemoneElement variationData;
		private static readonly int bulletMax;
		private SeaAnemoneBullet[] bulletArray;
		public float firstDelayWaitSecond;
		private static readonly string soundLabelStart;
		private Animator anim;
		private bool eventInitializedFlag;
		private bool eventSendFlag;
		private bool eventReceivedFlag;
		private int randomSeed;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _StartAction_d__11 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SeaAnemoneBody __4__this;
			private float _waitSec_5__2;
			private UnityEngine.Random.State _state_5__3;
			private List<CharacterBase> _targetList_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAction_d__11(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SeaAnemoneBody();
		static SeaAnemoneBody();
	
		// Methods
		protected override void Awake();
		[IteratorStateMachine]
		private IEnumerator StartAction();
		private void OnActionEnd();
		private void OnTriggerEnter(Collider other);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
	}
}
