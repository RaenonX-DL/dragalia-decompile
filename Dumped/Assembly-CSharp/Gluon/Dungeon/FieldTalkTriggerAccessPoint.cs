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
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FieldTalkTriggerAccessPoint : FieldTalkTrigger
	{
		// Fields
		[SerializeField]
		private string accessBuffLabel;
		[SerializeField]
		private bool hideEnemyIcon;
		[SerializeField]
		public int linkHouseId;
		private static readonly int loopEffectTriggerAcceessNG;
		private static readonly int loopEffectTriggerAcceessOK;
		private static readonly int loopEffectTriggerInvisible;
		private bool enablePlayerAccessReq;
		private bool enablePlayerAccessLog;
		private EffectObject loopEffectObject;
		private float waitSecChangeEffectNow;
		private readonly float waitSecChangeEffectMax;
		private EffectStep effectStep;
		private bool finishPlayerAccessFlag;
	
		// Nested types
		private enum EffectStep
		{
			Waiting = 0,
			Vanish = 1,
			Finish = 2
		}
	
		[CompilerGenerated]
		private sealed class _SendAccessPointData_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FieldTalkTriggerAccessPoint __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SendAccessPointData_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FieldTalkTriggerAccessPoint();
		static FieldTalkTriggerAccessPoint();
	
		// Methods
		protected override void Awake();
		protected void Start();
		[IteratorStateMachine]
		protected IEnumerator SendAccessPointData();
		public override void FastUpdate();
		public void SetEnableAccess(bool enableFlag);
		private void SetLoopEffectTrigger(int id);
		protected override void OnCollided(GameObject target);
		public override void OnEvent(DungeonObject eventObject, GameObject target);
		public void SetTalkAndBuff();
		public bool IsAccessed();
	}
}
