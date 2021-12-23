using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class EffectData : ActionParts.PartsData
	{
		public enum GeneratePos
		{
			Owner,
			OwnerNode,
			Target,
			WorldCenter,
			Marker,
			SpecifyId,
			OwnerGround,
			TargetGround,
			AreaAnchor,
			TargetPlayer,
			CameraPos,
			OwnerToStartActionCharacter
		}

		public enum EraseCtrl
		{
			None,
			OwnerEntrust,
			Action,
			StateAttack
		}

		public enum TargetCharacterStatus
		{
			None,
			AllyHpRateLowest
		}

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _effectNameForLowestQuality;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private string _effectControlerKey;

		[SerializeField]
		[HideInInspector]
		private bool _isOverwriteKey;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _isReplaceTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _influencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _influencedCharacterMode;

		[SerializeField]
		[HideInInspector]
		private int _influencedCharacterModeOffset;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _useMarkerTrigger;

		[SerializeField]
		[HideInInspector]
		private EffectObject.FollowRotType _followRotType;

		[SerializeField]
		[HideInInspector]
		private float _nearestRange;

		[SerializeField]
		[HideInInspector]
		private bool _isFont;

		[SerializeField]
		[HideInInspector]
		private bool _effectTriggerJudgedByBaseId;

		[SerializeField]
		[HideInInspector]
		private int _sameBaseIdTrigger;

		[SerializeField]
		[HideInInspector]
		private int _differentBaseIdTrigger;

		[SerializeField]
		[HideInInspector]
		private GeneratePos _generatePos;

		[SerializeField]
		[HideInInspector]
		private bool _generateOnY0;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private bool _isRootAxisOffset;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetRot;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetScale;

		[SerializeField]
		[HideInInspector]
		private bool _useOwnerScale;

		[SerializeField]
		[HideInInspector]
		private bool _isFollowing;

		[SerializeField]
		[HideInInspector]
		private bool _isFollowOffForStop;

		[SerializeField]
		[HideInInspector]
		private bool _isHorizon;

		[SerializeField]
		[HideInInspector]
		private bool _isTakeOverRootDirection;

		[SerializeField]
		[HideInInspector]
		private bool _isTakeOverMoveDirection;

		[SerializeField]
		[HideInInspector]
		private bool _isTowardsTarget;

		[SerializeField]
		[HideInInspector]
		private bool _isTowardsTargetYaw;

		[SerializeField]
		[HideInInspector]
		private bool _isKeepOwnerDirection;

		[SerializeField]
		[HideInInspector]
		private bool _useTargetSizeOffset;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _eraseType;

		[SerializeField]
		[HideInInspector]
		private float _disappearTime;

		[SerializeField]
		[HideInInspector]
		private float _playSpeedScale;

		[SerializeField]
		[HideInInspector]
		private bool _isAdjustAttackSpeed;

		[SerializeField]
		[HideInInspector]
		private int _loadPositionId;

		[SerializeField]
		[HideInInspector]
		private int _savePositionId;

		[SerializeField]
		[HideInInspector]
		private EraseCtrl _eraseCtrl;

		[SerializeField]
		[HideInInspector]
		private bool _enableForceStop;

		[SerializeField]
		[HideInInspector]
		private bool _enableForceStopEffectWithControllerKeys;

		[SerializeField]
		[HideInInspector]
		private bool _isHitAttributeShift;

		[SerializeField]
		[HideInInspector]
		private string _effectNameHAS;

		[SerializeField]
		[HideInInspector]
		private bool _isInfluencedHiding;

		[SerializeField]
		[HideInInspector]
		private bool _useAnimatableObject;

		[SerializeField]
		[HideInInspector]
		private string _animatableObjectName;

		[SerializeField]
		[HideInInspector]
		private string _animatableObjectStateName;

		[SerializeField]
		[HideInInspector]
		private bool _isAnimatableObjectDeleteOnAnimEnd;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private bool _alwaysDispEffect;

		[SerializeField]
		[HideInInspector]
		private TargetCharacterStatus _targetCharaStatus;

		[SerializeField]
		[HideInInspector]
		private float _searchTargetRange;

		public string effectName => null;

		public string effectNameForLowestQuality => null;

		public string[] elementalEffectName => null;

		public string controlerKey => null;

		public bool isOverwriteKey => default(bool);

		public int trigger => default(int);

		public bool isReplaceTrigger => default(bool);

		public bool influencedCharaterElement => default(bool);

		public bool influencedCharacterMode => default(bool);

		public int influencedCharacterModeOffset => default(int);

		public bool useElementalTrigger => default(bool);

		public bool useMarkerTrigger => default(bool);

		public EffectObject.FollowRotType followRotType => default(EffectObject.FollowRotType);

		public float nearestRange => default(float);

		public bool isFont => default(bool);

		public bool effectTriggerJudgedByBaseId => default(bool);

		public int sameBaseIdTrigger => default(int);

		public int differentBaseIdTrigger => default(int);

		public GeneratePos generatePos => default(GeneratePos);

		public bool generateOnY0 => default(bool);

		public string attachNodeName => null;

		public bool isRootAxisOffset => default(bool);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 offsetRot => default(Vector3);

		public Vector3 offsetScale => default(Vector3);

		public bool useOwnerScale => default(bool);

		public bool isFollowing => default(bool);

		public bool isFollowOffForStop => default(bool);

		public bool isHorizon => default(bool);

		public bool isTakeOverRootDirection => default(bool);

		public bool isTakeOverMoveDirection => default(bool);

		public bool isTowardsTarget => default(bool);

		public bool isTowardsTargetYaw => default(bool);

		public bool isKeepOwnerDirection => default(bool);

		public bool useTargetSizeOffset => default(bool);

		public EffectObject.EraseType eraseType => default(EffectObject.EraseType);

		public float disappearTime => default(float);

		public float playSpeedScale => default(float);

		public bool isAdjustAttackSpeed => default(bool);

		public int loadPositionId => default(int);

		public int savePositionId => default(int);

		public EraseCtrl eraseCtrl => default(EraseCtrl);

		public bool enableForceStop => default(bool);

		public bool enableForceStopEffectWithControllerKeys => default(bool);

		public bool isHitAttributeShift => default(bool);

		public string effectNameHAS => null;

		public bool isInfluencedHiding => default(bool);

		public bool useAnimatableObject => default(bool);

		public string animatableObjectName => null;

		public string animatableObjectStateName => null;

		public bool isAnimatableObjectDeleteOnAnimEnd => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public bool alwaysDispEffect => default(bool);

		public TargetCharacterStatus targetCharaStatus => default(TargetCharacterStatus);

		public float searchTargetRange => default(float);

		public void Copy(EffectData src)
		{
		}
	}
}
