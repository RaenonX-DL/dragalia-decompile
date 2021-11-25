using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class AlloutAssaultUniqueCtrl : EnemyUniqueCtrl, ICollideCallback
	{
		public enum EventType
		{
			Eight,
			Angel
		}

		public enum State
		{
			Init,
			Idle,
			Running,
			Down,
			Standup
		}

		private EventType _eventType;

		private State _state;

		[SerializeField]
		private float _limit;

		[SerializeField]
		private float _point;

		private float _timer;

		private bool _isShowCutt;

		private bool _hasPlayed;

		private bool _isCreatedUI;

		private CollisionHitAttribute _hitAttribute;

		protected HitException _hitException;

		private List<int> _listMenberId;

		private string[] _voiceLabel;

		private AudioPlayback _voice;

		private float _nextSendGaugeValueEventTimer;

		private static readonly float SendGaugeValueEventInterval;

		public EventType eventType => default(EventType);

		public State state => default(State);

		public float rate => default(float);

		public bool isDisplayedBtn
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void Initialize()
		{
		}

		public void Setup(SetupAlloutAssaultData resource)
		{
		}

		public void OnStart(CollisionHitAttribute hitAttr)
		{
		}

		public override void FastUpdate()
		{
		}

		private void Ready()
		{
		}

		private void CreateUI()
		{
		}

		public bool CheckDown()
		{
			return default(bool);
		}

		public bool OnDown()
		{
			return default(bool);
		}

		public bool ProcStandup()
		{
			return default(bool);
		}

		public void OnDamage(CollisionHitAttribute hitAttr, int damage)
		{
		}

		private bool CanAssaultCondition()
		{
			return default(bool);
		}

		private bool CanAssaultCondition_ForEight()
		{
			return default(bool);
		}

		private bool CanAssaultCondition_ForAngel()
		{
			return default(bool);
		}

		public void OnBtnAssault()
		{
		}

		public void OnEndCutScene()
		{
		}

		public void OnEndAlloutAssault()
		{
		}

		public override float GetAtkValue()
		{
			return default(float);
		}

		public override float GetDefValue()
		{
			return default(float);
		}

		public void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		public void OnNotCollided(CharacterBase chara)
		{
		}

		public bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		private bool IsEightMember(CharacterBase target)
		{
			return default(bool);
		}

		private void PlayReadyVoice()
		{
		}

		private void PlayReadyVoice_Eight()
		{
		}

		public void SendAlloutAssaultDown()
		{
		}

		public void SendAlloutAssaultDownGaugeValue()
		{
		}

		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent)
		{
		}
	}
}
