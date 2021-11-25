using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon.Bullet
{
	public class BindBulletObject : BulletObjectWithMarker
	{
		public enum MoveType
		{
			Stay,
			Straight
		}

		private MoveType _moveType;

		private CollisionHitAttribute _releaseHitAttr;

		protected HitException _releaseHitException;

		private long _bindEventId;

		private List<CharacterBase> _boundList;

		private bool _hasBound;

		private float _bindingTime;

		private float timer
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int effectTrigger_Release
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float bindHeight
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Initialize(CharacterBase owner, CommonObjectStatus target, Vector3 position, Quaternion rotation, MoveType moveType, float bulletDuration, MarkerData markerData, float waitCount, int traceDelay, string releaseHitAttrLabel = "", long bindEventId = 0L, float tempoScale = 1f, float bindingTime = 0f)
		{
			return default(bool);
		}

		protected override void Clear()
		{
		}

		protected override bool State_BulletRun()
		{
			return default(bool);
		}

		private void RunStay()
		{
		}

		private void RunStraight()
		{
		}

		protected override bool State_After()
		{
			return default(bool);
		}

		private void ProcReleaseBind()
		{
		}

		public override void OnCollided(GameObject goTarget, bool isPropagation)
		{
		}

		public override bool IsExcept(CharacterBase chara)
		{
			return default(bool);
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		private void CreateHitAttribute(string label, ActionCollision collision, ref CollisionHitAttribute hit)
		{
		}
	}
}
