/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class CommandData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private CharacterCommand _charaCommand;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
		[HideInInspector]
		[SerializeField]
		private bool _onoff;
		[HideInInspector]
		[SerializeField]
		private int _id;
		[HideInInspector]
		[SerializeField]
		private int _num;
		[HideInInspector]
		[SerializeField]
		private float _rate;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private float _delayTime;
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offset;
		[HideInInspector]
		[SerializeField]
		private float _displayTime;
		[HideInInspector]
		[SerializeField]
		private string _effectCtrlKey;
		[HideInInspector]
		[SerializeField]
		private int _effectTrigger;
		[HideInInspector]
		[SerializeField]
		private int _changeTextureIndex;
		[HideInInspector]
		[SerializeField]
		private bool _isActionClear;
		[HideInInspector]
		[SerializeField]
		private RegisterPositionType _registerType;
		[HideInInspector]
		[SerializeField]
		private RegisterMultiPositionType _registerMultiType;
		[HideInInspector]
		[SerializeField]
		private int _registerMultiMarkerGroupId;
		[HideInInspector]
		[SerializeField]
		private ChlidType _childType;
		[HideInInspector]
		[SerializeField]
		private CharacterCommand _childCommand;
		[HideInInspector]
		[SerializeField]
		private string _bulletDistinctionTag;
		[HideInInspector]
		[SerializeField]
		private string _skillTitle;
		[HideInInspector]
		[SerializeField]
		private int _weakActionId;
		[HideInInspector]
		[SerializeField]
		private bool _isTarget;
		[HideInInspector]
		[SerializeField]
		private string[] _targetCtrlObjectNames;
		[HideInInspector]
		[SerializeField]
		private bool _isSkipThisActionEndPlayIdleMotion;
		[HideInInspector]
		[SerializeField]
		private string _soundCtrlKey;
		[HideInInspector]
		[SerializeField]
		private float _soundFadeTime;
		[HideInInspector]
		[SerializeField]
		private int _bgmBlockIdx;
		[HideInInspector]
		[SerializeField]
		private DungeonBgModelProduction.ChangeBgProductionKind _productionKind;
		[HideInInspector]
		[SerializeField]
		private DungeonBgModelProduction.BgModelGroup _bgModelGroup;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _productionAnimationCurve;
		[HideInInspector]
		[SerializeField]
		private float _productionDelay01;
		[HideInInspector]
		[SerializeField]
		private float _productionDelay02;
		[HideInInspector]
		[SerializeField]
		private int _attachEffIdx;
		[HideInInspector]
		[SerializeField]
		private bool _overrideTargetOnCurrentAction;
		[HideInInspector]
		[SerializeField]
		private MultiTargetType _multiTargetType;
		[HideInInspector]
		[SerializeField]
		private AttachObjectCategory _attachObjectCategory;
	
		// Properties
		public CharacterCommand command { get; }
		public bool guarantee { get; }
		public bool onoff { get; }
		public int id { get; }
		public int num { get; }
		public float rate { get; }
		public string effectName { get; }
		public float delayTime { get; }
		public string attachNodeName { get; }
		public Vector3 offset { get; }
		public float displayTime { get; }
		public string effectCtrlKey { get; }
		public int effectTrigger { get; }
		public int changeTextureIndex { get; }
		public bool isActionClear { get; }
		public RegisterPositionType registerType { get; }
		public RegisterMultiPositionType registerMultiType { get; }
		public int registerMultiMarkerGroupId { get; }
		public ChlidType childType { get; }
		public CharacterCommand childCommand { get; }
		public string bulletDistinctionTag { get; }
		public string skillTitle { get; }
		public int weakActionId { get; }
		public bool isTarget { get; }
		public string[] targetCtrlObjectNames { get; }
		public bool isSkipThisActionEndPlayIdleMotion { get; }
		public string soundCtrlKey { get; }
		public float soundFadeTime { get; }
		public int bgmBlockIdx { get; }
		public DungeonBgModelProduction.ChangeBgProductionKind productionKind { get; }
		public DungeonBgModelProduction.BgModelGroup bgModelGroup { get; }
		public AnimationCurve productionAnimationCurve { get; }
		public float productionDelay01 { get; }
		public float productionDelay02 { get; }
		public int attachEffIdx { get; }
		public bool overrideTargetOnCurrentAction { get; }
		public MultiTargetType multiTargetType { get; }
		public AttachObjectCategory attachObjectCategory { get; }
	
		// Nested types
		public enum CharacterCommand
		{
			Dummy_03 = 0,
			Leave = 1,
			Dummy_01 = 2,
			Dummy_02 = 3,
			PartDemolishUI = 4,
			EnemySkillTitle = 5,
			ResetAbnormal = 6,
			DelayEffect = 7,
			AllPartsRepair = 8,
			EffectControl = 9,
			TargetReticleUI = 10,
			SpecialHate = 11,
			SyncTargetToSub = 12,
			RegisterPosition = 13,
			ChildCommand = 14,
			BulletDelete = 15,
			DisableCheckOutside = 16,
			WeakAction = 17,
			TargetOnOff = 18,
			RegisterMultiPosition = 19,
			SkipThisActionEndPlayIdleMotion = 20,
			EnemyAiSpecialMode = 21,
			Invincible = 22,
			SoundCtrlStop = 23,
			ResetPitchRoll = 24,
			SwitchBgmBlock = 25,
			SwitchBgModel = 26,
			AttachEffTrigger = 27,
			ExtraActionMode = 28,
			SetCharaMarkUIVisibility = 29,
			PlayerPushOnOff = 30,
			ResistBuffDebuff = 31,
			WeaponVisible = 32,
			ResetTension = 33,
			SelectMultiTarget = 34,
			ResetBuffDebuff = 35,
			ResistAllAbnormal = 36,
			AttachObject = 37,
			SetMoveSyncDisabled = 38,
			ScaleOverdrivePoint = 39,
			AllUnitInvincible = 40,
			Stop1 = 41,
			DisplayMyHpToPartsUI = 42,
			RESERVE_24 = 43,
			RESERVE_25 = 44,
			RESERVE_26 = 45,
			RESERVE_27 = 46,
			RESERVE_28 = 47,
			RESERVE_29 = 48,
			RESERVE_30 = 49,
			RESERVE_31 = 50,
			RESERVE_32 = 51,
			RESERVE_33 = 52,
			RESERVE_34 = 53,
			RESERVE_35 = 54,
			RESERVE_36 = 55,
			RESERVE_37 = 56,
			RESERVE_38 = 57,
			RESERVE_39 = 58,
			RESERVE_40 = 59,
			RESERVE_41 = 60,
			RESERVE_42 = 61,
			RESERVE_43 = 62,
			RESERVE_44 = 63,
			RESERVE_45 = 64,
			RESERVE_46 = 65,
			RESERVE_47 = 66,
			RESERVE_48 = 67,
			RESERVE_49 = 68,
			RESERVE_50 = 69
		}
	
		public enum RegisterPositionType
		{
			Owner = 0,
			Target = 1,
			Marker = 2
		}
	
		public enum RegisterMultiPositionType
		{
			MarkerGroupId = 0
		}
	
		public enum ChlidType
		{
			Chiled01 = 0,
			Chiled02 = 1,
			Chiled03 = 2
		}
	
		public enum MultiTargetType
		{
			Multi_P1 = 0,
			Multi_P2 = 1,
			Multi_P3 = 2,
			Multi_P4 = 3
		}
	
		public enum AttachObjectCategory
		{
			None = 0,
			WeaponSkin = 1
		}
	
		// Constructors
		public CommandData();
	}
}
