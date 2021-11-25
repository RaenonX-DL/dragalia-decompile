using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlEventHeal : CUGCtrlBase, ICollideCallback
	{
		public enum State
		{
			NotReady,
			Wait,
			Charging,
			FullCharge,
			Unavailable,
			End
		}

		private const float POINT_MAX = 1000f;

		[SerializeField]
		private float _point;

		private float _pointSpeed;

		private float _timer;

		private float _waitTime;

		private CollisionHitAttribute _hitAttribute;

		private AlloutAssaultUniqueCtrl _assault;

		private string _effName;

		private EffectObject _eoSkill;

		private string _seName;

		private State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override CharacterBase owner => null;

		public override bool active => default(bool);

		public float point
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float rate => default(float);

		private Transform transform => null;

		public void Setup(CharacterSelector selector, CharacterBase owner_, CollisionHitAttribute hitAttr, float chargeTime, float waitTime)
		{
		}

		public void SetupEffect(string effName, string seName)
		{
		}

		private void Reset()
		{
		}

		public override void ResetState()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		private bool CanHealCondition()
		{
			return default(bool);
		}

		public void OnBtnEventHeal()
		{
		}

		public override void OnDead()
		{
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

		private void PlayReadyVoice()
		{
		}
	}
}
