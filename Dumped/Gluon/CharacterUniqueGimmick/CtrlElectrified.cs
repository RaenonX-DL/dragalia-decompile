using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlElectrified : CUGCtrlBase, ICollideCallback
	{
		public enum State
		{
			Idle,
			Start,
			Charging,
			AddStack,
			Discharge,
			Abort,
			End
		}

		private State _state;

		public const int STACK_MAX = 4;

		private CollisionHitAttribute[] _hitAttribute;

		protected HitException _hitException;

		private float[] _dmgRate;

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

		public State state
		{
			get
			{
				return default(State);
			}
			private set
			{
			}
		}

		public override bool active => default(bool);

		public int stackNum
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private Transform transform => null;

		public void Setup(CharacterSelector target, CollisionHitAttribute[] hitAttribute, float duration, float[] argDmgRate)
		{
		}

		private void Reset()
		{
		}

		public override void ResetState()
		{
		}

		public void Start()
		{
		}

		public override void Abort()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private void AddStack()
		{
		}

		public override void OnDead()
		{
		}

		private void Discharge()
		{
		}

		public override void PlayEffect()
		{
		}

		public override void StopEffect()
		{
		}

		public void DeleteEffect()
		{
		}

		private void UpdateEffect()
		{
		}

		public override void OnCollided(CollisionHitAttribute hitAttr)
		{
		}

		public void OnAddStack()
		{
		}

		private void OnDischarge()
		{
		}

		public virtual void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public virtual void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public virtual void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public float GetDamageRate()
		{
			return default(float);
		}

		public void OnReceiveEvent(ElectrifyEvent recvData)
		{
		}

		public static void CreateElectrifiedUI()
		{
		}

		private void ShowElectrifiedUI()
		{
		}

		private void HideElectrifiedUI()
		{
		}

		private void SetElectrifiedUIGaugeTimer()
		{
		}

		private void SetElectrifiedUIStackNum()
		{
		}

		private void SendElectrifyEvent()
		{
		}

		private void ProcessReceivedEvent()
		{
		}
	}
}
