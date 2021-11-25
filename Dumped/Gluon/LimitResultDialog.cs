using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LimitResultDialog : CommonPopup
	{
		public GameObject growResultLimitStar;

		public LimitStarBase beforeLimitStar;

		public LimitStarBase afterLimitStar;

		public Image baseIcon;

		public Text beforeLimitLevel;

		public Text afterLimitLevel;

		public GrowResultGetSkill growResultGetSkill;

		public Transform amuletBase;

		public Image beforeIcon;

		public Image afterIcon;

		public Transform limitBreakParam;

		public Transform levelMaxParam;

		public GameObject canReleaseNextLimitBreakObj;

		[SerializeField]
		private Text resultText;

		[SerializeField]
		private Text starText;

		[SerializeField]
		private Text lvText;

		[SerializeField]
		private Text getSkillText;

		[SerializeField]
		private Text amuletText;

		[SerializeField]
		private GameObject albumPanelParent;

		private List<GrowResultDialogType> resultStateList;

		private GrowResultBaseData oldBaseData;

		private GrowResultBaseData newBaseData;

		public Action<GrowResultDialogType> closeButtonCallBack;

		public bool isReleaseAmuletLv3;

		private bool isAlbumPanel;

		public static LimitResultDialog Create(bool showBlackLayer = false)
		{
			return null;
		}

		public void SetupResultDialog(GrowResultBaseData oldData, GrowResultBaseData updateData)
		{
		}

		public void OnToPowerupButtonPressed()
		{
		}

		public void OnToAlbumButtonPressed()
		{
		}

		private void GoGrowthScene()
		{
		}

		public void OKButtonPressed()
		{
		}

		private void ShowDialog()
		{
		}

		private void ShowDiffLimit()
		{
		}

		private bool ShowPowerUpSkill(GrowResultDialogType type)
		{
			return default(bool);
		}

		private void SetBottomButton()
		{
		}
	}
}
