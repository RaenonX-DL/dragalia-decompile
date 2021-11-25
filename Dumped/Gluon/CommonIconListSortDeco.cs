using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonIconListSortDeco : MonoBehaviour
	{
		private const string prefabPath = "Prefabs/OutGame/Common/CommonIconListSortDeco";

		private const string prefabPathL = "Prefabs/OutGame/Common/CommonIconListSortDecoL";

		public const string prefabPath56 = "Prefabs/OutGame/Common/CommonIconListSortDeco56";

		public const int yellowColorIndicator = 1000000;

		public const int aquaColorIndicator = 4000000;

		public static readonly Color yellowColor;

		public static readonly Color aquaColor;

		private const int legendAbilityCrestMinRarity = 9;

		[SerializeField]
		[Header("Text")]
		public Text textOnlyText;

		public Text levelPrefix;

		[SerializeField]
		[Header("BGs")]
		public GameObject charaBG;

		public GameObject weaponAmuletBG;

		public GameObject dragonBG;

		[SerializeField]
		[Header("Optional Icon or Prefix")]
		public GameObject manaCirclePrefixGO;

		public GameObject friendshipPrefixGO;

		public GameObject battlePointPrefixGO;

		public GameObject levelPrefixGO;

		[SerializeField]
		[Header("Groups")]
		public GameObject normalGroup;

		public GameObject limitBreakGroup;

		public GameObject rarityGroup;

		public GameObject charaRarityGroup;

		[SerializeField]
		private GameObject legendAbilityCrestRarityGroup;

		[SerializeField]
		[Header("GroupIcons")]
		public GameObject[] rarityIcons;

		public GameObject[] charaRarityIcons;

		public GameObject[] limitBreakIcons;

		public GameObject limitBreak5Icon;

		public Sprite limitBreak5DisableSprite;

		public Sprite limitBreak5EnableSprite;

		[SerializeField]
		private GameObject legendAbilityCrestRarityIcon;

		[SerializeField]
		[Header("BG")]
		public CanvasGroup grayMaskCanvasGroup;

		public void ClearDisplay()
		{
		}

		public void SetTextColor(Color col)
		{
		}

		public static int SetDecoNumWithColor(int num, bool yellow, bool aqua)
		{
			return default(int);
		}

		public static CommonIconListSortDeco Create(Transform parent, IconLoader.Size iconSize)
		{
			return null;
		}

		public static CommonIconListSortDeco Create(Transform parent, string specificPrefabPath)
		{
			return null;
		}

		public static int GetCharaLevelDecoNum(int charaId, int level, int rarity, int additionalMaxLevel)
		{
			return default(int);
		}

		public static Color GetCharaLevelColor(int charaId, int level, int rarity, int additionalMaxLevel)
		{
			return default(Color);
		}

		public static int GetUnitLevelDecoNum(int level, int maxLevel, int limitBreakLevel, int maxLimitBreakLevel = 4)
		{
			return default(int);
		}

		public static Color GetCommonIconListSortDecoColor(CommonParamCalculate.OutGame.ManaCircleTextColor manaColor)
		{
			return default(Color);
		}

		public void SetupByNumAndCondition(Color color, int value, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType sortType, CommonSortModel.Preset usingPreset = CommonSortModel.Preset.AutoCommon, [Optional] CommonIconListCellData listCellData)
		{
		}

		public void SetupByNumAndCondition(int decoNum, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType sortType, CommonSortModel.Preset usingPreset = CommonSortModel.Preset.AutoCommon, [Optional] CommonIconListCellData listCellData)
		{
		}

		public void SetupByNumAndCondition(int decoNum, GiftType giftType, [Optional] CommonSortModel.Condition condition, [Optional] CommonIconListCellData listCellData)
		{
		}

		public void SetGrayOutStyle(bool isGrayOut)
		{
		}

		public void SetupPlusTextParent(Transform plusTextTransform)
		{
		}

		public void SetSpecialSkillText(bool isShow)
		{
		}
	}
}
