using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon.CharacterUniqueGimmick
{
	public class CtrlGrudge : CUGCtrlBase, ICollideCallback
	{
		public enum State
		{
			Idle,
			AddStack,
			Vent,
			Abort,
			End
		}

		private CollisionHitAttribute _hitAttribute;

		private HitException _hitException;

		public const int STACK_MAX = 5;

		private int[] _fixedDamage;

		public const string GRUDGE_EFFECT_NAME = "EFF_BOS_DRG_20000601_012";

		private const int EFF_VENT_TRIG = 13;

		private EffectObject _eoGrudge;

		public State state
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

		public void Setup(CharacterSelector owner, CollisionHitAttribute hitAttribute)
		{
		}

		private void Reset()
		{
		}

		public override void ResetState()
		{
		}

		public override void Abort()
		{
		}

		public override void Update(CharacterBase src)
		{
		}

		public void OnAddStack()
		{
		}

		private void AddStack()
		{
		}

		public void OnVent()
		{
		}

		private void Vent()
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

		public override void PlayEffect()
		{
		}

		public override void StopEffect()
		{
		}

		public void DeleteEffect()
		{
		}

		public void SetFixedDamage(int stack_num, int damage)
		{
		}

		public void OnReceiveEvent(CharacterSpecialState recvData)
		{
		}

		private void SendGrudgeEvent(bool isVent)
		{
		}
	}
}
