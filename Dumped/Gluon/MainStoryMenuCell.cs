using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MainStoryMenuCell : GradientCell
	{
		public SimpleAnimationCell animationCell;

		public Image baseImage;

		[SerializeField]
		private RectTransform baseButton;

		[SerializeField]
		private GameObject questNewIconRoot;

		[SerializeField]
		private GameObject questNewGlowRoot;

		[SerializeField]
		private Button summaryButton;

		[SerializeField]
		[Header("Campaign")]
		protected CampaignButtons campaignButton;

		private FlashPlayer flashNewIcon;

		private FlashPlayer flashNewGlow;

		private int chapterNum;

		private QuestSelectScene.Difficulty difficulty;

		private bool isGoLastQuest;

		private FlashPlayerManager flashPlayerManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void SetContent(bool isShowArrow, FlashPlayerManager flashPlayerManager)
		{
		}

		private QuestUtil.QuestState GetMainQuestMenuState(int targetChapter)
		{
			return default(QuestUtil.QuestState);
		}

		private QuestUtil.QuestState GetQuestState(int targetChapter, QuestSelectScene.Difficulty difficulty)
		{
			return default(QuestUtil.QuestState);
		}

		private void SetQuestStateIcon(QuestUtil.QuestState state)
		{
		}

		private static void SetActiveScale(GameObject obj, bool isActive)
		{
		}

		public virtual void OnCellTouched()
		{
		}

		public virtual void OnSummaryPressed()
		{
		}

		private void GotoChapterArea(int chapterNum, QuestSelectScene.Difficulty difficulty)
		{
		}

		public override bool SetGradientShader()
		{
			return default(bool);
		}

		public static QuestMainGroupElement GetQuestMainGroupElement(int chapterNum)
		{
			return null;
		}

		public void SetupStorySummaryButton(bool isEnable)
		{
		}
	}
}
