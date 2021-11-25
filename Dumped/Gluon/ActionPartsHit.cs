using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsHit : ActionParts
	{
		private readonly HitData _partsData;

		private readonly long _partsDataId;

		private float timeCount;

		private float _dynamicScaleElapsed;

		protected HitException _hitException;

		private CollisionHitAttribute hitAttribute;

		private CharacterBase _firstTargetPlayer;

		private float _baseCollisionLength;

		private float _baseCollisionWidth;

		private float _baseCollisionHeight;

		private Vector3 lastKnownPosition
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private GameObject substituteTarget
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ActionPartsHit(Gluon.ActionData.ActionParts resource, long resourceId)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void ConvertHitAttribute()
		{
		}

		private void ConvertHitAttributeForPlayer(string label)
		{
		}

		private void ConvertHitAttributeForEnemy(string label)
		{
		}

		private void SetupCollisionParameter(HitData data)
		{
		}

		private void CollisionScale()
		{
		}

		private void DynamicScale(float delta)
		{
		}

		private string GetLabel()
		{
			return null;
		}

		public int GetActionConditionId(CharacterBase chara, int skillId)
		{
			return default(int);
		}

		public PlayerActionHitAttributeElement GetPlayerActionHitAttribute(CharacterBase chara)
		{
			return null;
		}

		private void PlayHitSE(CharacterBase target, Vector3 pos)
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}
	}
}
