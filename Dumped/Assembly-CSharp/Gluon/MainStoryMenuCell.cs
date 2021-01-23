/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MainStoryMenuCell : GradientCell
	{
		// Fields
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
		[Header]
		[SerializeField]
		protected CampaignButtons campaignButton;
		[CompilerGenerated]
		private FlashPlayerManager _flashPlayerManager_k__BackingField;
		private FlashPlayer flashNewIcon;
		private FlashPlayer flashNewGlow;
		private int chapterNum;
		private QuestSelectScene.Difficulty difficulty;
		private bool isGoLastQuest;
	
		// Properties
		private FlashPlayerManager flashPlayerManager { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public QuestSelectSummaryPopup popup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnSummaryPressed_b__0();
		}
	
		// Constructors
		public MainStoryMenuCell();
	
		// Methods
		private void Awake();
		public void SetContent(bool isShowArrow, FlashPlayerManager flashPlayerManager);
		private QuestUtil.QuestState GetMainQuestMenuState(int targetChapter);
		private QuestUtil.QuestState GetQuestState(int targetChapter, QuestSelectScene.Difficulty difficulty);
		private void SetQuestStateIcon(QuestUtil.QuestState state);
		private static void SetActiveScale(GameObject obj, bool isActive);
		public virtual void OnCellTouched();
		public virtual void OnSummaryPressed();
		private void GotoChapterArea(int chapterNum, QuestSelectScene.Difficulty difficulty);
		public override bool SetGradientShader();
		public static QuestMainGroupElement GetQuestMainGroupElement(int chapterNum);
		public void SetupStorySummaryButton(bool isEnable);
		[CompilerGenerated]
		private void _SetContent_b__17_0(Material material);
	}
}
