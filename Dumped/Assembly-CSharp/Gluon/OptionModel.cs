/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionModel
	{
		// Fields
		private static OptionModel instance;
		public const string optionPrefString = "OptionSetting";
		public bool isUpdatedFromServer;
		private List<SettingChangedListenerInfo> settingChangedListeners;
		public Setting setting;
	
		// Properties
		public static OptionModel Instance { get; }
	
		// Nested types
		public enum SettingEventType
		{
			FPS = 0,
			GraphicQuality = 1,
			Resolution = 2,
			MyPageBG = 3
		}
	
		private class SettingChangedListenerInfo
		{
			// Fields
			public string uniqueID;
			public Action<int> action;
			public SettingEventType eventType;
	
			// Constructors
			public SettingChangedListenerInfo();
		}
	
		public class SettingBase
		{
			// Constructors
			public SettingBase();
	
			// Methods
			public virtual void ResetToDefault();
		}
	
		[Serializable]
		public class Setting : SettingBase
		{
			// Fields
			public SoundSetting soundSetting;
			public GameSetting gameSetting;
			public SystemSetting systemSetting;
			public NotificationSetting notificationSetting;
			[SerializeField]
			private bool _initOptionValueSet;
	
			// Properties
			public bool initOptionValueSet { get; set; }
	
			// Nested types
			[Serializable]
			public class SoundSetting : SettingBase
			{
				// Fields
				public BGMSetting bgmSetting;
				public VocalSetting vocalSetting;
				public SESetting seSetting;
				public VoiceSetting voiceSetting;
	
				// Nested types
				[Serializable]
				public class BGMSetting : SettingBase
				{
					// Fields
					public bool isOn;
					public int settingValue;
	
					// Constructors
					public BGMSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class VocalSetting : SettingBase
				{
					// Fields
					public VocalType vocalType;
	
					// Nested types
					public enum VocalType
					{
						On = 0,
						Off = 1,
						Humming = 2
					}
	
					// Constructors
					public VocalSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class SESetting : SettingBase
				{
					// Fields
					public bool isOn;
					public int settingValue;
	
					// Constructors
					public SESetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class VoiceSetting : SettingBase
				{
					// Fields
					public bool isOn;
					public int settingValue;
	
					// Constructors
					public VoiceSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				// Constructors
				public SoundSetting();
	
				// Methods
				public override void ResetToDefault();
			}
	
			[Serializable]
			public class GameSetting : SettingBase
			{
				// Fields
				public GraphicSetting graphicSetting;
				public CameraSetting cameraSetting;
				public DisplaySetting displaySetting;
				public SensorySetting sensorySetting;
				public QuickTurnSetting quickTurnSetting;
				public AutoUkemiSetting autoUkemiSetting;
				public ConfirmElementSetting confirmElementSetting;
				public SkinWeaponSetting skinWeaponSetting;
	
				// Nested types
				[Serializable]
				public class GraphicSetting : SettingBase
				{
					// Fields
					public const int lowFPS = 30;
					public const int highFPS = 60;
					public QualityType graphicQuality;
					public int fps;
					public ResolutionType resolution;
					public bool otherCharaEffect;
	
					// Nested types
					private enum ResultKeywordStatus
					{
						Empty = 0,
						Success = 1,
						Failed = 2
					}
	
					public enum QualityType
					{
						Lowest = 0,
						Low = 1,
						Medium = 2,
						High = 3
					}
	
					public enum ResolutionType
					{
						Medium = 0,
						MediumHigh = 1,
						High = 2
					}
	
					// Constructors
					public GraphicSetting();
	
					// Methods
					public override void ResetToDefault();
					public void SetToRecommendation();
					private ResultKeywordStatus CheckKeyword(string source, string keyword);
					public QualityType GetDefaultQualityType();
				}
	
				[Serializable]
				public class CameraSetting : SettingBase
				{
					// Fields
					public bool isShake;
					public bool isAutoZoom;
					public bool isShowSkillCameraMove;
	
					// Constructors
					public CameraSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class DisplaySetting : SettingBase
				{
					// Fields
					public bool isSwapCharacterAndSkill;
					public bool isLeftHanded;
					public bool isShowSkillCutin;
	
					// Constructors
					public DisplaySetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class SensorySetting : SettingBase
				{
					// Fields
					public FlickSensoryType flickSensitivity;
	
					// Nested types
					public enum FlickSensoryType
					{
						Lowest = 0,
						Low = 1,
						Medium = 2,
						High = 3,
						Highest = 4
					}
	
					// Constructors
					public SensorySetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class QuickTurnSetting : SettingBase
				{
					// Fields
					public bool isEnable180;
					public bool isEnable90;
	
					// Constructors
					public QuickTurnSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class AutoUkemiSetting : SettingBase
				{
					// Fields
					public bool isEnable;
	
					// Constructors
					public AutoUkemiSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class ConfirmElementSetting : SettingBase
				{
					// Fields
					public bool isEnable;
	
					// Constructors
					public ConfirmElementSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				[Serializable]
				public class SkinWeaponSetting : SettingBase
				{
					// Fields
					public bool isEnable;
	
					// Constructors
					public SkinWeaponSetting();
	
					// Methods
					public override void ResetToDefault();
				}
	
				// Constructors
				public GameSetting();
	
				// Methods
				public override void ResetToDefault();
			}
	
			[Serializable]
			public class SystemSetting : SettingBase
			{
				// Fields
				public MyPageBGMode myPageBGMode;
				public ManacircleViewMode manacircleViewMode;
				public int myPageBgmId;
				public DragonStrokeViewMode dragonStrokeViewMode;
				public bool pettingGyro;
				public TextSpeedType textSpeed;
				public AutoLockSetting autoLockSetting;
				public bool autoSkipReadSetting;
				public bool performanceMode;
				public bool androidStatusBarOn;
				public bool androidNavigationBarOn;
	
				// Nested types
				public enum TextSpeedType
				{
					Low = 0,
					Medium = 1,
					High = 2
				}
	
				public enum MyPageBGMode
				{
					BG2D = 0,
					BG3D = 1
				}
	
				public enum ManacircleViewMode
				{
					View2D = 0,
					View3D = 1
				}
	
				public enum DragonStrokeViewMode
				{
					View2D = 0,
					View3D = 1
				}
	
				public class AutoLockSetting : SettingBase
				{
					// Fields
					public bool isAutoLockUnit;
					public bool autoLockDragonSR;
					public bool autoLockDragonSSR;
	
					// Constructors
					public AutoLockSetting();
	
					// Methods
					public override void ResetToDefault();
					public AutoLockSetting MakeClone();
					public bool EqualsTo(AutoLockSetting other);
				}
	
				// Constructors
				public SystemSetting();
	
				// Methods
				public override void ResetToDefault();
			}
	
			[Serializable]
			public class NotificationSetting : SettingBase
			{
				// Fields
				public bool allowOfficialNotifications;
				public bool allowSingleStaminaNotifications;
				public bool allowMultiStaminaNotifications;
				public bool allowDragonSmithNotifications;
				public bool allowBuildDoneNotifications;
				public bool allowGoldFarmNotifications;
				public bool allowDragonTreeFullNotifications;
				public bool allowHoneyDrinkFullNotifications;
				public bool isSleepTimeOn;
				public int sleepStartHour;
				public int sleepStartMin;
				public int sleepEndHour;
				public int sleepEndMin;
	
				// Constructors
				public NotificationSetting();
	
				// Methods
				public override void ResetToDefault();
				public NotificationSetting MakeClone();
				public bool EqualsTo(NotificationSetting other);
			}
	
			// Constructors
			public Setting();
	
			// Methods
			public override void ResetToDefault();
			public void SwitchPerformanceMode(bool toPerformanceMode);
		}
	
		// Constructors
		private OptionModel();
		static OptionModel();
	
		// Methods
		public void AddSettingChangedListener(Action<int> listener, SettingEventType eventType, string methodUniqueID = null);
		public void RemoveSettingChangedListener(Action<int> listener);
		public void RemoveSettingChangedListenerByUniqueID(string methodUniqueID);
		public void InvokeOnSettingChangedForType(SettingEventType type, int value);
		private static bool MemberWiseEqual<T>(T left, T right)
			where T : class;
		public void OnInitSettingDone();
		public static void ApplySoundOptions(Setting useSetting = null);
		public static void ApplyGraphicSetting(bool force);
		public static void ApplyFlickSensitivity();
		public static void ApplyOptionsOnBoot();
		private bool LoadSetting();
		public static bool IsOptionAndoirdSpecificStatusBarOn();
		public static bool IsOptionAndoirdSpecificNavigationBarOn();
		public static bool isSettingExist(bool checkInitOption = true);
		public void SyncByServerSetting();
		public void SaveSetting();
		public static bool IsVoiceOn();
		public static bool CantPlayOtherCharaEffects();
	}
}
