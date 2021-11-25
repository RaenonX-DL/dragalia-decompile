using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsOdCounteredHit : ActionParts
	{
		private enum State
		{
			Init,
			MarkerSet,
			MarkerRun,
			HitRun,
			End
		}

		public enum IconBasePosition
		{
			Marker,
			Owner,
			Stage,
			AreaAnchor
		}

		private readonly OdCounteredHitData _partsData;

		private readonly long _partsDataId;

		private EnemyCharacter ownerEnemy;

		private float timeCount;

		private float _dynamicScaleElapsed;

		private CollisionHitAttribute hitAttribute;

		protected HitException _hitException;

		private CharacterBase _firstTargetPlayer;

		private float _baseCollisionLength;

		private float _baseCollisionWidth;

		private float _baseCollisionHeight;

		private State _state;

		private bool _1stFrame;

		private ChargeMarker _marker;

		private Transform _iconBase;

		private Vector2 _counterIconOffset;

		private bool _canCounter;

		public ActionPartsOdCounteredHit(Gluon.ActionData.ActionParts resource, long resourceId)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
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

		private void MarkerSet()
		{
		}

		private void MarkerRun(float delta)
		{
		}

		private void HitSet()
		{
		}

		private void HitRun(float delta)
		{
		}

		private void ConvertHitAttribute(string label)
		{
		}

		private void SetupCollisionParameter(OdCounteredHitData data)
		{
		}

		private void CollisionScale()
		{
		}

		private void DynamicScale()
		{
		}

		private string GetLabel()
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

		private void CheckOdCounter()
		{
		}
	}
}
