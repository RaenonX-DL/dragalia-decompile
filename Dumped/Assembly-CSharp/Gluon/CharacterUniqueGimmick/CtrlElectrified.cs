/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlElectrified : CUGCtrlBase, ICollideCallback
	{
		// Fields
		private State _state;
		public const int STACK_MAX = 4;
		private CollisionHitAttribute[] _hitAttribute;
		protected HitException _hitException;
		private float[] _dmgRate;
		[CompilerGenerated]
		private int _stackNum_k__BackingField;
		private float _duration;
		private float _timer;
		private CharacterSelector _target;
		public const string ELECT_EFFECT_NAME = "EFF_BOS_DRG_20000501_008";
		public const string DISCHARGE_EFFECT_NAME = "EFF_BOS_DRG_20000501_009";
		public const string SE_NAME = "SE_DRG_210041_01_0027";
		private EffectObject _eoElect;
		private EffectObject _eoDischarge;
		private List<ElectrifyEvent> _recvEventList;
		private bool _isWaitingForDischardOnDead;
	
		// Properties
		public State state { get; private set; }
		public override bool active { get; }
		public int stackNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private Transform transform { get; }
	
		// Nested types
		public enum State
		{
			Idle = 0,
			Start = 1,
			Charging = 2,
			AddStack = 3,
			Discharge = 4,
			Abort = 5,
			End = 6
		}
	
		// Constructors
		public CtrlElectrified(CUGCtrl.Type type_);
	
		// Methods
		public void Setup(CharacterSelector target, CollisionHitAttribute[] hitAttribute, float duration, float[] argDmgRate);
		private void Reset();
		public override void ResetState();
		public void Start();
		public override void Abort();
		public override void Update();
		private void AddStack();
		public override void OnDead();
		private void Discharge();
		public override void PlayEffect();
		public override void StopEffect();
		public void DeleteEffect();
		private void UpdateEffect();
		public override void OnCollided(CollisionHitAttribute hitAttr);
		public void OnAddStack();
		private void OnDischarge();
		public virtual void OnCollided(GameObject target, bool isPropagation);
		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		public virtual void OnNotCollided(CharacterBase chara);
		public bool IsExcept(CharacterBase chara);
		public float GetDamageRate();
		public void OnReceiveEvent(ElectrifyEvent recvData);
		public static void CreateElectrifiedUI();
		private void ShowElectrifiedUI();
		private void HideElectrifiedUI();
		private void SetElectrifiedUIGaugeTimer();
		private void SetElectrifiedUIStackNum();
		private void AddBattleLogUI();
		private void SendElectrifyEvent();
		private void ProcessReceivedEvent();
	}
}
