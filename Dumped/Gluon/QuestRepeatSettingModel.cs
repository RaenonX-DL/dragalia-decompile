using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;

namespace Gluon
{
	public class QuestRepeatSettingModel
	{
		public enum RepeatSetting
		{
			Off,
			UseAllStamina,
			Specified
		}

		private static QuestRepeatSettingModel instance;

		public RepeatSetting setting;

		public int userSetCount;

		public List<int> enabledAutoUseItemIdList;

		public const int maxTargetCount = 99;

		public const float autoContinueCountdown = 3.5f;

		private List<AtgenBuildEventRewardEntityList> overDiscardEntityList;

		private List<AtgenBuildEventRewardEntityList> overPresentEntityList;

		public static QuestRepeatSettingModel Instance => null;

		public static bool HasInstance => default(bool);

		public int TargetCount => default(int);

		public int finishedCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool shouldTerminateNextResult
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void DeleteInstance()
		{
		}

		private QuestRepeatSettingModel()
		{
		}

		static QuestRepeatSettingModel()
		{
		}

		public static QuestRepeatSettingModel CloneInstance()
		{
			return null;
		}

		public QuestRepeatSettingModel Clone()
		{
			return null;
		}

		private void RecordOverLimitByData(DataManager.GameData<AtgenBuildEventRewardEntityList> dmList, ref List<AtgenBuildEventRewardEntityList> selfList)
		{
		}

		public void RecordOverLimit()
		{
		}

		public void RestoreOverLimit()
		{
		}

		public static void Save(QuestRepeatSettingModel src)
		{
		}

		public static bool IsRepeatOn()
		{
			return default(bool);
		}

		public static Gluon.Http.RepeatSetting GetRepeatSetting()
		{
			return null;
		}

		public static void OnInGameOnOffButtonToggled(bool toOn)
		{
		}

		public bool AddSpecifiedLoopCountAndCheckQuit()
		{
			return default(bool);
		}

		public bool IsStaminaEnoughForNextLoop(int requiredStamina)
		{
			return default(bool);
		}

		public List<AtgenUseItemList> GetNeedUseItemListForStamina(int requiredStamina)
		{
			return null;
		}
	}
}
