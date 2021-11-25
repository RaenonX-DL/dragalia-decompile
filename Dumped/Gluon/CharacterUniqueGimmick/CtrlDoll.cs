using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlDoll : CUGCtrlBase
	{
		public enum State
		{
			Idle,
			Doll,
			Abort,
			Field
		}

		public enum DamageType
		{
			Invincible,
			None,
			Immunity
		}

		private State _state;

		private CharacterBase _hexer;

		private DamageType _dmgType;

		private float _duration;

		private float _timer;

		private bool _isTimeUp;

		private bool _killOnRelease;

		private bool _cancelAbnormal;

		private bool _visible;

		private bool checkDragon;

		private string _dollEffName;

		private EffectObject _eoDoll;

		private const int EFF_TRIG_DOLL = 8;

		private const int EFF_TRIG_CANCEL = 1;

		private int _timeupEffTrigger;

		private string _dollSeName;

		private string _timeupSeName;

		private string _logId;

		private Vector2 _centerOfField;

		private float _radiusOfField;

		private float _limitTimeOfField;

		private float _timerInField;

		private float _supportStartTime;

		private List<DollEvent> _recvEventList;

		private bool _isAbortReserved;

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

		public bool canTransform
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

		public override void OnDead()
		{
		}

		public void Setup(CharacterBase owner, CharacterSelector selector, DamageType dmgtype, bool killOnRelease, bool cancelAbnormal, bool visible)
		{
		}

		public void SetupEffect(string eff_name = "", string se_name = "", string log_id = "", int timeupEffTrigger = 0, string timeup_se_name = "")
		{
		}

		public override void ResetState()
		{
		}

		public bool CanStart()
		{
			return default(bool);
		}

		public void Start(CharacterBase hexer, float duration, bool canTransform_)
		{
		}

		public override void Abort()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private void ProcBegin(CharacterBase hexer)
		{
		}

		private bool CheckReleaseCondition()
		{
			return default(bool);
		}

		private void ProcAbort()
		{
		}

		public void StartField(CharacterBase hexer, float duration, bool canTransform_, float durationOfField, Vector2 centerOfField, float radiusOfField, float limitTimeOfField)
		{
		}

		private void ProcField()
		{
		}

		public void StopField()
		{
		}

		public bool CanReleaseOnHit(CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		public override void OnCollided(CollisionHitAttribute hitAttr)
		{
		}

		public override void OnStartSupport()
		{
		}

		public override void OnEndSupport()
		{
		}

		public override bool IsRestoreEffect()
		{
			return default(bool);
		}

		private void PlayEffectLocal()
		{
		}

		private new void StopEffect()
		{
		}

		public void DeleteEffect()
		{
		}

		private void SendDollEvent(State state)
		{
		}

		public void OnReceiveEvent(DollEvent recvData)
		{
		}

		private void ProcessReceivedEvent()
		{
		}
	}
}
