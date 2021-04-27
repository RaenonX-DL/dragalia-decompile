/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIconListSortDeco : MonoBehaviour
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Common/CommonIconListSortDeco";
		private const string prefabPathL = "Prefabs/OutGame/Common/CommonIconListSortDecoL";
		public const string prefabPath56 = "Prefabs/OutGame/Common/CommonIconListSortDeco56";
		public const int yellowColorIndicator = 1000000;
		public const int aquaColorIndicator = 4000000;
		public static readonly Color yellowColor;
		public static readonly Color aquaColor;
		private const int legendAbilityCrestMinRarity = 9;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text textOnlyText;
		public UnityEngine.UI.Text levelPrefix;
		[Header]
		[SerializeField]
		public GameObject charaBG;
		public GameObject weaponAmuletBG;
		public GameObject dragonBG;
		[Header]
		[SerializeField]
		public GameObject manaCirclePrefixGO;
		public GameObject friendshipPrefixGO;
		public GameObject battlePointPrefixGO;
		public GameObject levelPrefixGO;
		[Header]
		[SerializeField]
		public GameObject normalGroup;
		public GameObject limitBreakGroup;
		public GameObject rarityGroup;
		public GameObject charaRarityGroup;
		[SerializeField]
		private GameObject legendAbilityCrestRarityGroup;
		[Header]
		[SerializeField]
		public GameObject[] rarityIcons;
		public GameObject[] charaRarityIcons;
		public GameObject[] limitBreakIcons;
		[SerializeField]
		private GameObject legendAbilityCrestRarityIcon;
		[Header]
		[SerializeField]
		public CanvasGroup grayMaskCanvasGroup;
	
		// Constructors
		public CommonIconListSortDeco();
		static CommonIconListSortDeco();
	
		// Methods
		public void ClearDisplay();
		public void SetTextColor(Color col);
		public static int SetDecoNumWithColor(int num, bool yellow, bool aqua);
		public static CommonIconListSortDeco Create(Transform parent, IconLoader.Size iconSize);
		public static CommonIconListSortDeco Create(Transform parent, string specificPrefabPath);
		public static int GetCharaLevelDecoNum(int charaId, int level, int rarity, int additionalMaxLevel);
		public static Color GetCharaLevelColor(int charaId, int level, int rarity, int additionalMaxLevel);
		public static int GetUnitLevelDecoNum(int level, int maxLevel, int limitBreakLevel);
		public static Color GetCommonIconListSortDecoColor(CommonParamCalculate.OutGame.ManaCircleTextColor manaColor);
		public void SetupByNumAndCondition(Color color, int value, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType sortType, CommonSortModel.Preset usingPreset = CommonSortModel.Preset.AutoCommon, CommonIconListCellData listCellData = null);
		public void SetupByNumAndCondition(int decoNum, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType sortType, CommonSortModel.Preset usingPreset = CommonSortModel.Preset.AutoCommon, CommonIconListCellData listCellData = null);
		public void SetupByNumAndCondition(int decoNum, GiftType giftType, CommonSortModel.Condition condition = null, CommonIconListCellData listCellData = null);
		public void SetGrayOutStyle(bool isGrayOut);
		public void SetupPlusTextParent(Transform plusTextTransform);
		public void SetSpecialSkillText(bool isShow);
	}
}
