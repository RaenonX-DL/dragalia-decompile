using System;
using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class BattleRoyalModel
	{
		public class BattleRecord
		{
			public int rank;

			public int kill;

			public int dateTime;

			public int skinOrCharaId;

			public WeaponType job;
		}

		public enum TalkDataCategory
		{
			Top = 1,
			Result,
			Hint,
			JobDescription
		}

		private static BattleRoyalModel instance;

		private const string prefsJobSettingTemplate = "__BR_JobSettingDic_{0}";

		private const string prefsJobWeaponSettingTemplate = "__BR_JobWeaponSettingDic_{0}";

		public static BattleRoyalModel Instance => null;

		public List<WeaponType> weaponTypeList => null;

		public List<int> charaSkinList => null;

		public Dictionary<WeaponType, int> jobSettingDic => null;

		public Dictionary<WeaponType, int> jobWeaponSettingDic => null;

		public int totalTop1Count => default(int);

		public int totalTop4Count => default(int);

		public WeaponType mostUsedJob => default(WeaponType);

		public int killTotalCount => default(int);

		public int maxKillCountPerGame => default(int);

		public int currentPoint => default(int);

		public int cyclePoint => default(int);

		public int totalPoint => default(int);

		public List<BattleRecord> battleRecordList => null;

		public static int eventId => default(int);

		public static int questId => default(int);

		public static void DeleteInstance()
		{
		}

		public static bool IsInstanceNull()
		{
			return default(bool);
		}

		private BattleRoyalModel()
		{
		}

		static BattleRoyalModel()
		{
		}

		public void SetJobSetting(WeaponType weaponType, int skinId)
		{
		}

		public void SetJobWeaponSetting(WeaponType weaponType, int skinId)
		{
		}

		public static bool GetCurrentOrNextAvailableDateTime(out DateTime startTime, out DateTime endTime)
		{
			return default(bool);
		}

		public List<BattleRoyalEventItemElement> GetEnabledSkinListForType(WeaponType wt)
		{
			return null;
		}

		public string GetHintMessage()
		{
			return null;
		}

		public static bool IsPickupCharaSkin(int charaSkinId)
		{
			return default(bool);
		}

		public void SendReleaseCharaSkinData(int charaSkinId, Action<int> onComplete)
		{
		}
	}
}
