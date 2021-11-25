using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsLevelHit : ActionParts
	{
		private readonly LevelHitData _partsData;

		private readonly long _partsDataId;

		protected HitException _hitException;

		private float timeCount;

		private float _dynamicScaleElapsed;

		private float _baseCollisionLength;

		private float _baseCollisionWidth;

		private float _baseCollisionHeight;

		private CollisionHitAttribute hitAttribute
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

		public ActionPartsLevelHit(Gluon.ActionData.ActionParts resource, long resourceId)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		private void SetupHitAttribute(int lv)
		{
		}

		private string GetLabel(int lv)
		{
			return null;
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void SetupCollisionParameter(LevelHitData data)
		{
		}

		private void CollisionScale()
		{
		}

		private void DynamicScale()
		{
		}

		public override void OnCollided(GameObject target, bool isPropagation)
		{
		}

		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot)
		{
		}

		private void PlayHitSE(CharacterBase target, Vector3 pos)
		{
		}
	}
}
