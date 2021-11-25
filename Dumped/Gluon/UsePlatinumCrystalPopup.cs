using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UsePlatinumCrystalPopup : CommonPopup
	{
		public Text topMessageText;

		public GameObject statusLabelBase;

		public GameObject statusHPBase;

		public Text statusHPBefore;

		public Text statusHPAfter;

		public GameObject statusAtkBase;

		public Text statusAtkBefore;

		public Text statusAtkAfter;

		public GameObject statusLevelBase;

		public Text statusLevelBefore;

		public Text statusLevelAfter;

		public GameObject statusComboBase;

		public Text statusComboBefore;

		public Text statusComboAfter;

		public GameObject skillLabelBase;

		public Transform skillListParentTransform;

		public GameObject originSkillIcon;

		public Transform materialListParentTransform;

		public GameObject originMaterialCell;

		public const int platinumCrystalMaterialId = 125001001;

		public static UsePlatinumCrystalPopup Create()
		{
			return null;
		}

		public void InitPopup(UnitDetailModel.CharaDetailData charaDetailData, GrowthManaCircleManaPieceData[] manaPieceDataList)
		{
		}

		public static int GetCharaMaxGrowthMaxLevel(GrowthManaCircleManaPieceData[] pieceDatas, CharaDataElement charaData)
		{
			return default(int);
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}
	}
}
