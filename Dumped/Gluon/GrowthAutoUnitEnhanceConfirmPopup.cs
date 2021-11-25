using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthAutoUnitEnhanceConfirmPopup : CommonPopup
	{
		public Text topMessageText;

		public Text beforeHpText;

		public Text afterHpText;

		public GameObject hpTextUIBase;

		public Text beforeAtkText;

		public Text afterAtkText;

		public GameObject atkTextUIBase;

		public Text beforeWeaponAbilityCount;

		public Text afterWeaponAbilityCount;

		public GameObject WeaponAbilityUIBase;

		public Image breforeType1SlotImage;

		public Text breforeType1SlotText;

		public Image breforeType2SlotImage;

		public Text breforeType2SlotText;

		public Image breforeType3SlotImage;

		public Text breforeType3SlotText;

		public Image afterType1SlotImage;

		public Text afterType1SlotText;

		public Image afterType2SlotImage;

		public Text afterType2SlotText;

		public Image afterType3SlotImage;

		public Text afterType3SlotText;

		public GameObject WeaponSlotTypeUIBase;

		public Text beforeWeaponBonusHpText;

		public Text afterWeaponBonusHpText;

		public Text beforeWeaponBonusAtkText;

		public Text afterWeaponBonusAtkText;

		public GameObject WeaponBonusHpUIBase;

		public GameObject WeaponBonusAtkUIBase;

		public GameObject originCell;

		public Transform cellParentTransform;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public GameObject[] crestEnhanceDisabelUIObjects;

		public Text popHeadText;

		private GrowthUnitEnhanceModel model;

		private int totalNeedRupi;

		private Dictionary<int, int> useMaterialDict;

		private readonly Color positiveColor;

		private readonly Color normalColor;

		public int totalReleaseCount
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

		public int canReleaseBuildupCount
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

		public int[] canReleasePassiveAilityIds
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int canReleaseSlotType1
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

		public int canReleaseSlotType2
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

		public int canReleaseSlotType3
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

		public int canReleaseWeaponBonusCount
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

		public static GrowthAutoUnitEnhanceConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		private void SteupStatusParam()
		{
		}

		private void SetupWeaponPassiveAbility()
		{
		}

		private void SetupSlotCount()
		{
		}

		private void SetupWeaponBonus()
		{
		}

		private void SetupMaterialCell()
		{
		}

		private void SetupRupi()
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}
	}
}
