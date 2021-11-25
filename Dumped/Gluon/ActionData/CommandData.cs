using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class CommandData : ActionParts.PartsData
	{
		public enum CharacterCommand
		{
			Dummy_03,
			Leave,
			Dummy_01,
			Dummy_02,
			PartDemolishUI,
			EnemySkillTitle,
			ResetAbnormal,
			DelayEffect,
			AllPartsRepair,
			EffectControl,
			TargetReticleUI,
			SpecialHate,
			SyncTargetToSub,
			RegisterPosition,
			ChildCommand,
			BulletDelete,
			DisableCheckOutside,
			WeakAction,
			TargetOnOff,
			RegisterMultiPosition,
			SkipThisActionEndPlayIdleMotion,
			EnemyAiSpecialMode,
			Invincible,
			SoundCtrlStop,
			ResetPitchRoll,
			SwitchBgmBlock,
			SwitchBgModel,
			AttachEffTrigger,
			ExtraActionMode,
			SetCharaMarkUIVisibility,
			PlayerPushOnOff,
			ResistBuffDebuff,
			WeaponVisible,
			ResetTension,
			SelectMultiTarget,
			ResetBuffDebuff,
			ResistAllAbnormal,
			AttachObject,
			SetMoveSyncDisabled,
			ScaleOverdrivePoint,
			AllUnitInvincible,
			Stop1,
			DisplayMyHpToPartsUI,
			ServantAction,
			DropDp,
			DamageImmunity,
			SwitchWeaponSkin,
			SetFace,
			ApplyBuffDebuff,
			SetFollowerTargetToPlayerTarget,
			RESERVE_31,
			RESERVE_32,
			RESERVE_33,
			RESERVE_34,
			RESERVE_35,
			RESERVE_36,
			RESERVE_37,
			RESERVE_38,
			RESERVE_39,
			RESERVE_40,
			RESERVE_41,
			RESERVE_42,
			RESERVE_43,
			RESERVE_44,
			RESERVE_45,
			RESERVE_46,
			RESERVE_47,
			RESERVE_48,
			RESERVE_49,
			RESERVE_50
		}

		public enum RegisterPositionType
		{
			Owner,
			Target,
			Marker
		}

		public enum RegisterMultiPositionType
		{
			MarkerGroupId
		}

		public enum ChlidType
		{
			Chiled01,
			Chiled02,
			Chiled03
		}

		public enum MultiTargetType
		{
			Multi_P1,
			Multi_P2,
			Multi_P3,
			Multi_P4
		}

		public enum AttachObjectCategory
		{
			None,
			WeaponSkin
		}

		[SerializeField]
		[HideInInspector]
		private CharacterCommand _charaCommand;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		[SerializeField]
		[HideInInspector]
		private bool _onoff;

		[SerializeField]
		[HideInInspector]
		private int _id;

		[SerializeField]
		[HideInInspector]
		private int _num;

		[SerializeField]
		[HideInInspector]
		private float _rate;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private float _delayTime;

		[SerializeField]
		[HideInInspector]
		private string _attachNodeName;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offset;

		[SerializeField]
		[HideInInspector]
		private Vector3 _ofsRot;

		[SerializeField]
		[HideInInspector]
		private Vector3 _ofsScl;

		[SerializeField]
		[HideInInspector]
		private float _displayTime;

		[SerializeField]
		[HideInInspector]
		private string _effectCtrlKey;

		[SerializeField]
		[HideInInspector]
		private int _effectTrigger;

		[SerializeField]
		[HideInInspector]
		private int _changeTextureIndex;

		[SerializeField]
		[HideInInspector]
		private bool _isActionClear;

		[SerializeField]
		[HideInInspector]
		private RegisterPositionType _registerType;

		[SerializeField]
		[HideInInspector]
		private RegisterMultiPositionType _registerMultiType;

		[SerializeField]
		[HideInInspector]
		private int _registerMultiMarkerGroupId;

		[SerializeField]
		[HideInInspector]
		private ChlidType _childType;

		[SerializeField]
		[HideInInspector]
		private CharacterCommand _childCommand;

		[SerializeField]
		[HideInInspector]
		private string _bulletDistinctionTag;

		[SerializeField]
		[HideInInspector]
		private string _skillTitle;

		[SerializeField]
		[HideInInspector]
		private int _weakActionId;

		[SerializeField]
		[HideInInspector]
		private bool _isTarget;

		[SerializeField]
		[HideInInspector]
		private string[] _targetCtrlObjectNames;

		[SerializeField]
		[HideInInspector]
		private bool _isSkipThisActionEndPlayIdleMotion;

		[SerializeField]
		[HideInInspector]
		private string _soundCtrlKey;

		[SerializeField]
		[HideInInspector]
		private float _soundFadeTime;

		[SerializeField]
		[HideInInspector]
		private int _bgmBlockIdx;

		[SerializeField]
		[HideInInspector]
		private DungeonBgModelProduction.ChangeBgProductionKind _productionKind;

		[SerializeField]
		[HideInInspector]
		private DungeonBgModelProduction.BgModelGroup _bgModelGroup;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _productionAnimationCurve;

		[SerializeField]
		[HideInInspector]
		private float _productionDelay01;

		[SerializeField]
		[HideInInspector]
		private float _productionDelay02;

		[SerializeField]
		[HideInInspector]
		private int _attachEffIdx;

		[SerializeField]
		[HideInInspector]
		private bool _overrideTargetOnCurrentAction;

		[SerializeField]
		[HideInInspector]
		private MultiTargetType _multiTargetType;

		[SerializeField]
		[HideInInspector]
		private AttachObjectCategory _attachObjectCategory;

		[SerializeField]
		[HideInInspector]
		private DragonCharacter.ServantActionCommand _servantActionCommandId;

		[SerializeField]
		[HideInInspector]
		private DamageImmunity.Type _damageImmType;

		[SerializeField]
		[HideInInspector]
		private bool _doNotExecuteCommandOnDeadChild;

		[SerializeField]
		[HideInInspector]
		private bool _doNotExecuteCommandOnRemotely;

		public CharacterCommand command => default(CharacterCommand);

		public bool guarantee => default(bool);

		public bool onoff => default(bool);

		public int id => default(int);

		public int num => default(int);

		public float rate => default(float);

		public string effectName => null;

		public float delayTime => default(float);

		public string attachNodeName => null;

		public Vector3 offset => default(Vector3);

		public Vector3 ofsRot => default(Vector3);

		public Vector3 ofsScl => default(Vector3);

		public float displayTime => default(float);

		public string effectCtrlKey => null;

		public int effectTrigger => default(int);

		public int changeTextureIndex => default(int);

		public bool isActionClear => default(bool);

		public RegisterPositionType registerType => default(RegisterPositionType);

		public RegisterMultiPositionType registerMultiType => default(RegisterMultiPositionType);

		public int registerMultiMarkerGroupId => default(int);

		public ChlidType childType => default(ChlidType);

		public CharacterCommand childCommand => default(CharacterCommand);

		public string bulletDistinctionTag => null;

		public string skillTitle => null;

		public int weakActionId => default(int);

		public bool isTarget => default(bool);

		public string[] targetCtrlObjectNames => null;

		public bool isSkipThisActionEndPlayIdleMotion => default(bool);

		public string soundCtrlKey => null;

		public float soundFadeTime => default(float);

		public int bgmBlockIdx => default(int);

		public DungeonBgModelProduction.ChangeBgProductionKind productionKind => default(DungeonBgModelProduction.ChangeBgProductionKind);

		public DungeonBgModelProduction.BgModelGroup bgModelGroup => default(DungeonBgModelProduction.BgModelGroup);

		public AnimationCurve productionAnimationCurve => null;

		public float productionDelay01 => default(float);

		public float productionDelay02 => default(float);

		public int attachEffIdx => default(int);

		public bool overrideTargetOnCurrentAction => default(bool);

		public MultiTargetType multiTargetType => default(MultiTargetType);

		public AttachObjectCategory attachObjectCategory => default(AttachObjectCategory);

		public DragonCharacter.ServantActionCommand servantActionCommandId => default(DragonCharacter.ServantActionCommand);

		public DamageImmunity.Type damageImmType => default(DamageImmunity.Type);

		public bool doNotExecuteCommandOnDeadChild => default(bool);

		public bool doNotExecuteCommandOnRemotely => default(bool);
	}
}
