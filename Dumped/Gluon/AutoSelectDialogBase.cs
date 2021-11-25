using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AutoSelectDialogBase : CommonPopup
	{
		protected enum ConfigTragetType
		{
			None,
			Weapon,
			Dragon,
			Amulet
		}

		public enum ConfigLevelType
		{
			None,
			OneOnly,
			All
		}

		public enum ConfigPlusType
		{
			None,
			ZeroOnly,
			PlusOnly,
			NoSelect
		}

		public enum ConfigType
		{
			Rarity,
			Level,
			Plus
		}

		public GameObject selectRarity;

		public GameObject selectLevel;

		public GameObject selectPlus;

		public const int defaultConfigDragonRarity = 3;

		public const int defaultConfigWeaponRarity = 2;

		public const int defaultConfigAmuletRarity = 2;

		public const int defaultConfigLevel = 1;

		public const int defaultConfigPlus = 1;

		private int configRarity;

		private int configLevel;

		private int configPlus;

		protected string rarityKey;

		protected string levelKey;

		protected string plusKey;

		protected ConfigTragetType targetType;

		[SerializeField]
		protected Text dialogMessageText;

		[SerializeField]
		private Text[] subTitleText;

		[SerializeField]
		private Text[] rarityText;

		[SerializeField]
		private Text[] levelText;

		[SerializeField]
		private Text[] plusText;

		[SerializeField]
		[Header("Count")]
		protected Text countText;

		[SerializeField]
		protected Text preCountText;

		private Func<int> getAutoSelectCount;

		private int countMax;

		public static T Create<T>(bool showBlackLayer = true) where T : AutoSelectDialogBase
		{
			return null;
		}

		protected void SetupConfigDialog(int countMax, Func<int> getAutoSelectCount)
		{
		}

		private void SetPlayerPrefs()
		{
		}

		public void SetCountText(int countNow)
		{
		}

		protected virtual void OkButtonPressed()
		{
		}

		public void OnToggleChanged(bool isOn)
		{
		}

		public static int[] GetAutoSelectConfigParam(string rarityKey, string levelKey, string plusKey, int defaultConfig)
		{
			return null;
		}
	}
}
