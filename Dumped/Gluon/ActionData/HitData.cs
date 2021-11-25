using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class HitData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private string _hitLabel;

		[SerializeField]
		[HideInInspector]
		private bool _useSameComponent;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		[SerializeField]
		[HideInInspector]
		private ActionCollision _collision;

		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _collisionPosId;

		[SerializeField]
		[HideInInspector]
		private CollisionTransform.SlotFrontType _SlotFrontType;

		[SerializeField]
		[HideInInspector]
		private float _nearestRange;

		[SerializeField]
		[HideInInspector]
		private Vector3 _collisionOffset;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_01;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_02;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_03;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_05;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_06;

		[SerializeField]
		[HideInInspector]
		private int _loadPositionId;

		[SerializeField]
		[HideInInspector]
		private int _savePositionId;

		[SerializeField]
		[HideInInspector]
		private bool _useSkinScale;

		[SerializeField]
		[HideInInspector]
		private bool _useScaleAtTheTime;

		[SerializeField]
		[HideInInspector]
		private float _collisionScale;

		[SerializeField]
		[HideInInspector]
		private bool _markerTargeting;

		[SerializeField]
		[HideInInspector]
		private bool _useDynamicScale;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _collisionDynamicScaleCurve;

		public const float DEFAULT_HIT_INTERVAL = 0.5f;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _applyActionSpeedToCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _useAccurateCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private EffectData _hitEffect;

		[SerializeField]
		[HideInInspector]
		private EffectData _bindEffect;

		[SerializeField]
		[HideInInspector]
		private string _hitSEName;

		[SerializeField]
		[HideInInspector]
		private bool _isPlayNormalHitSE;

		[SerializeField]
		[HideInInspector]
		private int _sameTimeHitId;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public string hitLabel => null;

		public bool useSameComponent => default(bool);

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;

		public ActionCollision collisionShape => default(ActionCollision);

		public ActionCollisionPos collisionPosId => default(ActionCollisionPos);

		public CollisionTransform.SlotFrontType slotFrontType => default(CollisionTransform.SlotFrontType);

		public float nearestRange => default(float);

		public Vector3 collisionOffset => default(Vector3);

		public float collisionParams01 => default(float);

		public float collisionParams02 => default(float);

		public float collisionParams03 => default(float);

		public float collisionParams05 => default(float);

		public float collisionParams06 => default(float);

		public int loadPositionId => default(int);

		public int savePositionId => default(int);

		public bool useSkinScale => default(bool);

		public bool useScaleAtTheTime => default(bool);

		public float collisionScale => default(float);

		public bool isMarkerTarget => default(bool);

		public bool useDynamicScale => default(bool);

		public AnimationCurve collisionDynamicScaleCurve => null;

		public float collisionHitInterval => default(float);

		public bool applyActionSpeedToCollisionHitInterval => default(bool);

		public bool useAccurateCollisionHitInterval => default(bool);

		public EffectData hitEffect => null;

		public EffectData bindEffect => null;

		public string hitSEName => null;

		public bool isPlayNormalHitSE => default(bool);

		public int sameTimeHitId => default(int);
	}
}
