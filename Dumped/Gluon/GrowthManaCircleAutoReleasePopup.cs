using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleAutoReleasePopup : CommonPopup
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

		public GameObject manaPointBase;

		public Text manaPointBefore;

		public Text manaPointAfter;

		public GameObject dewBase;

		public Text dewBefore;

		public Text dewAfter;

		public GameObject skillLabelBase;

		public Transform skillListParentTransform;

		public GameObject originSkillIcon;

		public Transform materialListParentTransform;

		public GameObject originMaterialCell;

		public Text warningText;

		public GameObject awakeButtonObject;

		private bool isReleasable;

		public static GrowthManaCircleAutoReleasePopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthManaCircleModel model, AutoReleasableAllCirclePointData autoReleasableData)
		{
		}

		private void SetMaterialDataDict(int materialId, int needCount, ref Dictionary<int, int> materialDict)
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		public void OnAwakeButtonPressed()
		{
		}
	}
}
