using System;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SettingHitData : ActionParts.PartsData
	{
		public enum HitType
		{
			Normal,
			FieldBuff
		}

		public enum ShareMode
		{
			None,
			EveryPlayerOnce
		}

		public enum TriggerRule
		{
			None,
			HPNotFull
		}

		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

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
		private float _lifetime;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _effectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _effectUseElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private EffectData _hitEffect;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		[SerializeField]
		[HideInInspector]
		private string _hitSEName;

		[SerializeField]
		[HideInInspector]
		private bool _isCommonHitNoSe;

		[SerializeField]
		[HideInInspector]
		private SettingHitObject.BasePosition _basePosition;

		[SerializeField]
		[HideInInspector]
		private float _nearest;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetRot;

		[SerializeField]
		[HideInInspector]
		private ActionCollision _collisionShape;

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

		public const float DEFAULT_HIT_INTERVAL = 0.5f;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _useAccurateCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private HitType _hitType;

		[SerializeField]
		[HideInInspector]
		private bool _useMarkerOnLowSetting;

		[SerializeField]
		[HideInInspector]
		private MarkerData _markerDataOnLowSetting;

		[SerializeField]
		[HideInInspector]
		private MarkerData _markerData;

		[SerializeField]
		[HideInInspector]
		private float _delayTime;

		[SerializeField]
		[HideInInspector]
		private string _markerEffectName;

		[SerializeField]
		[HideInInspector]
		private int _markerEffectTriggerStart;

		[SerializeField]
		[HideInInspector]
		private int _markerEffectTriggerStop;

		[SerializeField]
		[HideInInspector]
		private string _distinctionTag;

		[SerializeField]
		[HideInInspector]
		private int _sameTimeHitId;

		[SerializeField]
		[HideInInspector]
		private bool _needClearance;

		[SerializeField]
		[HideInInspector]
		private ShareMode _shareMode;

		[SerializeField]
		[HideInInspector]
		private TriggerRule _triggerRule;

		[SerializeField]
		[HideInInspector]
		private bool _forceApplyToAlly;

		[SerializeField]
		[HideInInspector]
		private int _maxLimit;

		[SerializeField]
		[HideInInspector]
		private bool _playOthersEffectOnLowSetting;

		[SerializeField]
		[HideInInspector]
		private bool _deleteWhenOwnerDie;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public string hitAttrLabel => null;

		public bool useSameComponent => default(bool);

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;

		public float lifetime => default(float);

		public string effectName => null;

		public string[] elementalEffectName => null;

		public int effectTriggerIdx => default(int);

		public bool effectInfluencedCharaterElement => default(bool);

		public bool effectUseElementalTrigger => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public EffectData hitEffect => null;

		public string seName => null;

		public string hitSEName => null;

		public bool isCommonHitNoSe => default(bool);

		public SettingHitObject.BasePosition basePosition => default(SettingHitObject.BasePosition);

		public float nearest => default(float);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 offsetRot => default(Vector3);

		public ActionCollision collisionShape => default(ActionCollision);

		public float collisionParams01 => default(float);

		public float collisionParams02 => default(float);

		public float collisionParams03 => default(float);

		public float collisionParams05 => default(float);

		public float collisionParams06 => default(float);

		public float collisionHitInterval => default(float);

		public bool useAccurateCollisionHitInterval => default(bool);

		public HitType hitType => default(HitType);

		public bool useMarkerOnLowSetting => default(bool);

		public MarkerData markerDataOnLowSetting => null;

		public MarkerData markerData => null;

		public float delayTime => default(float);

		public string markerEffectName => null;

		public int markerEffectTriggerStart => default(int);

		public int markerEffectTriggerStop => default(int);

		public string distinctionTag => null;

		public int sameTimeHitId => default(int);

		public bool needClearance => default(bool);

		public ShareMode shareMode => default(ShareMode);

		public TriggerRule triggerRule => default(TriggerRule);

		public bool forceApplyToAlly => default(bool);

		public int maxLimit => default(int);

		public bool playOthersEffectOnLowSetting => default(bool);

		public bool deleteWhenOwnerDie => default(bool);
	}
}
