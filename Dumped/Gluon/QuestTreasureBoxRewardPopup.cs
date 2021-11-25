using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestTreasureBoxRewardPopup : CommonPopup
	{
		private enum RewardIconType
		{
			Dragon,
			Weapon,
			Amulet
		}

		[SerializeField]
		public Text uiTitle;

		public Text uiSuccessText;

		public Text uiConditionTitle;

		public Text uiConditionText;

		public Image uiConditionTextUnderline;

		public RectTransform uiContents;

		[SerializeField]
		public GameObject uiCell;

		[SerializeField]
		private GameObject possessionRoot;

		[SerializeField]
		private Image rewardTypeIcon;

		[SerializeField]
		private Text posessionText;

		[SerializeField]
		private Text curPosessionNum;

		[SerializeField]
		private Text newPosessionNum;

		private readonly int underlineAddtionalLength;

		private UiImageExchanger iconExchanger;

		public static QuestTreasureBoxRewardPopup Create(QuestSelectScene qss, QuestMainLocationElement qmle, int chapterNumber, QuestSelectScene.Difficulty difficulty, bool isEnable, UnityAction onCloseCallback, bool showBlackLayer = true)
		{
			return null;
		}

		private void ReflectParam(QuestMainLocationElement qmle, int chapterNumber, QuestSelectScene.Difficulty difficulty, bool isEnable)
		{
		}

		private void SetDisp(Transform trans, bool value)
		{
		}
	}
}
