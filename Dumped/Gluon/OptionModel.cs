using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class OptionModel
	{
		public enum SettingEventType
		{
			FPS,
			GraphicQuality,
			Resolution,
			MyPageBG,
			AntiAliasing
		}

		private class SettingChangedListenerInfo
		{
			public string uniqueID;

			public Action<int> action;

			public SettingEventType eventType;
		}

		public class SettingBase
		{
			public virtual void ResetToDefault()
			{
			}
		}

		[Serializable]
		public class Setting : SettingBase
		{
			[Serializable]
			public class SoundSetting : SettingBase
			{
				[Serializable]
				public class BGMSetting : SettingBase
				{
					public bool isOn;

					public int settingValue;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class VocalSetting : SettingBase
				{
					public enum VocalType
					{
						On,
						Off,
						Humming
					}

					public VocalType vocalType;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class SESetting : SettingBase
				{
					public bool isOn;

					public int settingValue;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class VoiceSetting : SettingBase
				{
					public bool isOn;

					public int settingValue;

					public override void ResetToDefault()
					{
					}
				}

				public BGMSetting bgmSetting;

				public VocalSetting vocalSetting;

				public SESetting seSetting;

				public VoiceSetting voiceSetting;

				public override void ResetToDefault()
				{
				}
			}

			[Serializable]
			public class GameSetting : SettingBase
			{
				[Serializable]
				public class GraphicSetting : SettingBase
				{
					private enum ResultKeywordStatus
					{
						Empty,
						Success,
						Failed
					}

					public enum QualityType
					{
						Lowest,
						Low,
						Medium,
						High
					}

					public enum ResolutionType
					{
						Medium,
						MediumHigh,
						High
					}

					public const int lowFPS = 30;

					public const int highFPS = 60;

					public QualityType graphicQuality;

					public int fps;

					public ResolutionType resolution;

					public bool antiAliasing;

					public bool otherCharaEffect;

					public override void ResetToDefault()
					{
					}

					public void SetToRecommendation()
					{
					}

					private ResultKeywordStatus CheckKeyword(string source, string keyword)
					{
						return default(ResultKeywordStatus);
					}

					public QualityType GetDefaultQualityType()
					{
						return default(QualityType);
					}
				}

				[Serializable]
				public class CameraSetting : SettingBase
				{
					public bool isShake;

					public bool isAutoZoom;

					public bool isShowSkillCameraMove;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class DisplaySetting : SettingBase
				{
					public bool isSwapCharacterAndSkill;

					public bool isLeftHanded;

					public bool isShowSkillCutin;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class SensorySetting : SettingBase
				{
					public enum FlickSensoryType
					{
						Lowest,
						Low,
						Medium,
						High,
						Highest
					}

					public FlickSensoryType flickSensitivity;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class QuickTurnSetting : SettingBase
				{
					public bool isEnable180;

					public bool isEnable90;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class AutoUkemiSetting : SettingBase
				{
					public bool isEnable;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class ConfirmElementSetting : SettingBase
				{
					public bool isEnable;

					public override void ResetToDefault()
					{
					}
				}

				[Serializable]
				public class SkinWeaponSetting : SettingBase
				{
					public bool isEnable;

					public override void ResetToDefault()
					{
					}
				}

				public GraphicSetting graphicSetting;

				public CameraSetting cameraSetting;

				public DisplaySetting displaySetting;

				public SensorySetting sensorySetting;

				public QuickTurnSetting quickTurnSetting;

				public AutoUkemiSetting autoUkemiSetting;

				public ConfirmElementSetting confirmElementSetting;

				public SkinWeaponSetting skinWeaponSetting;

				public override void ResetToDefault()
				{
				}
			}

			[Serializable]
			public class SystemSetting : SettingBase
			{
				public enum TextSpeedType
				{
					Low,
					Medium,
					High
				}

				public enum MyPageBGMode
				{
					BG2D,
					BG3D
				}

				public enum ManacircleViewMode
				{
					View2D,
					View3D
				}

				public enum DragonStrokeViewMode
				{
					View2D,
					View3D
				}

				public class AutoLockSetting : SettingBase
				{
					public bool isAutoLockUnit;

					public bool autoLockDragonSR;

					public bool autoLockDragonSSR;

					public override void ResetToDefault()
					{
					}

					public AutoLockSetting MakeClone()
					{
						return null;
					}

					public bool EqualsTo(AutoLockSetting other)
					{
						return default(bool);
					}
				}

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

				public override void ResetToDefault()
				{
				}
			}

			[Serializable]
			public class NotificationSetting : SettingBase
			{
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

				public override void ResetToDefault()
				{
				}

				public NotificationSetting MakeClone()
				{
					return null;
				}

				public bool EqualsTo(NotificationSetting other)
				{
					return default(bool);
				}
			}

			public SoundSetting soundSetting;

			public GameSetting gameSetting;

			public SystemSetting systemSetting;

			public NotificationSetting notificationSetting;

			[SerializeField]
			private bool _initOptionValueSet;

			public bool initOptionValueSet
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public override void ResetToDefault()
			{
			}

			public void SwitchPerformanceMode(bool toPerformanceMode)
			{
			}
		}

		private static OptionModel instance;

		public const string optionPrefString = "OptionSetting";

		public bool isUpdatedFromServer;

		private List<SettingChangedListenerInfo> settingChangedListeners;

		public Setting setting;

		public static OptionModel Instance => null;

		private OptionModel()
		{
		}

		static OptionModel()
		{
		}

		public void AddSettingChangedListener(Action<int> listener, SettingEventType eventType, [Optional] string methodUniqueID)
		{
		}

		public void RemoveSettingChangedListener(Action<int> listener)
		{
		}

		public void RemoveSettingChangedListenerByUniqueID(string methodUniqueID)
		{
		}

		public void InvokeOnSettingChangedForType(SettingEventType type, int value)
		{
		}

		private static bool MemberWiseEqual<T>(T left, T right) where T : class
		{
			return default(bool);
		}

		public void OnInitSettingDone()
		{
		}

		public static void ApplySoundOptions([Optional] Setting useSetting)
		{
		}

		public static void ApplyGraphicSetting(bool force)
		{
		}

		public static void ApplyFlickSensitivity()
		{
		}

		public static void ApplyOptionsOnBoot()
		{
		}

		private bool LoadSetting()
		{
			return default(bool);
		}

		public static bool IsOptionAndoirdSpecificStatusBarOn()
		{
			return default(bool);
		}

		public static bool IsOptionAndoirdSpecificNavigationBarOn()
		{
			return default(bool);
		}

		public static bool isSettingExist(bool checkInitOption = true)
		{
			return default(bool);
		}

		public void SyncByServerSetting()
		{
		}

		public void SaveSetting()
		{
		}

		public static bool IsVoiceOn()
		{
			return default(bool);
		}

		public static bool CantPlayOtherCharaEffects()
		{
			return default(bool);
		}

		public static string GetGraphicsDeviceName()
		{
			return null;
		}

		public static bool IsEnableAntiAliasingDevice(string deviceName)
		{
			return default(bool);
		}
	}
}
