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
	public class QuestEventBannerPage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected Image descripImage;
		[SerializeField]
		private UnityEngine.UI.Text durationText;
		[SerializeField]
		private Button scheduleButton;
		[SerializeField]
		protected Button howtoButton;
		[SerializeField]
		protected Button[] timeAttackRankingButton;
		[SerializeField]
		private Image descripImageBg;
		[SerializeField]
		private Sprite[] descripImageBgSprite;
		[SerializeField]
		private Material[] descripImageBgMaterial;
		[SerializeField]
		private GameObject questWallTotalLevelNode;
		[SerializeField]
		private UnityEngine.UI.Text questWallTotalLeveltext;
		[SerializeField]
		private UnityEngine.UI.Text questWallResetTimeDescriptionText;
		[SerializeField]
		private ButtonWithSelectedImage questWallHowToReset;
		[SerializeField]
		protected Button instructorButton;
		[SerializeField]
		private ButtonWithSelectedImage instructorButtonWithSelectedImage;
		private const int specialEvent = 0;
		private const int normalEvents = 1;
		[SerializeField]
		private GameObject durationObj;
		[SerializeField]
		protected GameObject BonusObj;
		[SerializeField]
		protected Image weeklyTextImage;
		[SerializeField]
		protected Image dailyTextImage;
		[SerializeField]
		protected Image[] treasureBoxClosedImages;
		[SerializeField]
		protected Image[] treasureBoxOpenedImages;
		[SerializeField]
		protected Image completeImage;
		[SerializeField]
		protected UnityEngine.UI.Text resetText;
		[SerializeField]
		protected Transform dailyBonusCompleteParent;
		[SerializeField]
		protected Transform weeklyBonusCompleteParent;
		protected const int boxCount = 5;
		[SerializeField]
		protected GameObject questBonusObj;
		[SerializeField]
		protected GameObject bonusPlusImageObj;
		[SerializeField]
		protected GameObject bonusButton;
		[SerializeField]
		protected RectTransform buttonParent;
		protected QuestSelectInstance.QuestEventData curEventData;
		protected QuestEventElement eventElement;
		private bool isBonusCompleted;
		private float totalTime;
		protected bool isAnimating;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public int eventId;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _OnPageTouched_b__0();
		}
	
		// Constructors
		public QuestEventBannerPage();
	
		// Methods
		private void Awake();
		public virtual void SetContent(QuestSelectInstance.QuestEventData eventData);
		public static bool IsSkipCategoryPage(QuestSelectInstance.QuestEventData eventData, out QuestEventGroupElement anyEnabledElem);
		private static QuestEventGroupElement GetAnySpecialEvent(QuestSelectInstance.QuestEventData eventData);
		protected void SetQuestWallInfo(QuestEventElement eventElement);
		protected void SetBonusInformation(QuestEventElement eventElement);
		private void SetBonusBoxes(int openedCount, int maxCount, QuestResetIntervalType bonusType);
		private void SetBonusRemain();
		protected void SetRemainInfo(QuestEventElement eventElem);
		private void SetBg(QuestEventElement eventElement);
		protected void SetDurationInfo();
		protected void SetDurationText(UnityEngine.UI.Text targetText, bool isOneLine);
		public void OnScheduleButtonTouched();
		public void OnHowToButtonTouched();
		public void OnPageTouched();
		public void OnTimeAttackRankingButton();
		private void Update();
		protected void timeAttackRankingButtonSetActive(bool isActive);
		protected void timeAttackRankingButtonResetPressedState();
		public void OnInstructorButton();
		[CompilerGenerated]
		private void _SetContent_b__37_0(Material mat);
		[CompilerGenerated]
		private void _SetContent_b__37_1(Material mat);
		[CompilerGenerated]
		private void _OnScheduleButtonTouched_b__48_0();
		[CompilerGenerated]
		private void _OnHowToButtonTouched_b__49_0();
		[CompilerGenerated]
		private void _OnTimeAttackRankingButton_b__51_0();
		[CompilerGenerated]
		private void _OnInstructorButton_b__55_0();
	}
}
