using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowResultStatusDialog : CommonPopup
	{
		public Image baseIcon;

		public GrowResultDiffParam growResultDiffParam;

		public GrowResultGetSkill growResultGetSkill;

		public GameObject growResultLimitLevel;

		public GrowResultDialogType goOtherSceneResultType;

		public NeedLimitMaterialType needLimitMaterialType;

		[SerializeField]
		private Text lvText;

		[SerializeField]
		private Text hpText;

		[SerializeField]
		private Text atkText;

		[SerializeField]
		private Text powerText;

		[SerializeField]
		private RectTransform needLimitMaterialParent;

		[SerializeField]
		private Text limitLevelInfo;

		[SerializeField]
		private GameObject needLimitMaterialTypeParent;

		private List<GrowResultDialogType> resultStateList;

		private GrowResultBaseData oldBaseData;

		private GrowResultBaseData newBaseData;

		private bool isOkButtonManaCircle;

		public static GrowResultStatusDialog Create(bool showBlackLayer = false, GrowthBaseType growthBaseType = GrowthBaseType.Weapon)
		{
			return null;
		}

		public void SetupResultDialog(GrowResultBaseData oldData, GrowResultBaseData updateData, bool isLimitBreak)
		{
		}

		public void LimitBreakPressed()
		{
		}

		public void CancelButtonPressed()
		{
		}

		private void ShowDialog()
		{
		}

		private void ShowDiffParam()
		{
		}

		private void ShowMaxLevel(GrowResultDialogType type)
		{
		}

		private IEnumerator uiRebuildCorutine()
		{
			return null;
		}

		private void ShowMaxPlus()
		{
		}

		private void ClosePop()
		{
		}

		public void OnAlbumButton()
		{
		}

		public void OnManaCircleButton()
		{
		}
	}
}
