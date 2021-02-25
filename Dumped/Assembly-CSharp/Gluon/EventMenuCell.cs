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
	public class EventMenuCell : GradientCell
	{
		// Fields
		public SimpleAnimationCell animationCell;
		private const int expGroupId = 20101;
		private const int goldGoupId = 20206;
		private const int elementalGroupId = 20200;
		public Image baseImage;
		public UnityEngine.UI.Text remainText;
		[SerializeField]
		private Image rankingIcon;
		[SerializeField]
		private RectTransform baseButton;
		[SerializeField]
		private RectTransform baseButtonSpecial;
		[SerializeField]
		private Image arrow;
		[Header]
		[SerializeField]
		public GameObject expRibbon;
		public GameObject goldRibbon;
		public GameObject elementalRibbon;
		protected QuestEventGroupElement groupElement;
		protected QuestSelectInstance.QuestEventData curEventData;
		[SerializeField]
		private GameObject questNewIconRoot;
		[SerializeField]
		private GameObject questNewGlowRoot;
		[SerializeField]
		protected Image[] treasureBoxClosedImages;
		[SerializeField]
		protected Image[] treasureBoxOpenedImages;
		[SerializeField]
		protected GameObject bonusObj;
		[SerializeField]
		protected GameObject lockObj;
		[SerializeField]
		protected UnityEngine.UI.Text lockConditionText;
		[SerializeField]
		private int astralLockConditionTextFontSize;
		[SerializeField]
		protected GameObject[] balloonExpertObj;
		[Header]
		[SerializeField]
		private Transform campaignTrans;
		private CampaignButtons campaign;
		[SerializeField]
		protected CampaignButtons campaignButton;
		[CompilerGenerated]
		private FlashPlayerManager _flashPlayerManager_k__BackingField;
		private FlashPlayer flashNewIcon;
		private FlashPlayer flashNewGlow;
		private string campaginPath;
		private static readonly int bonusAnimationHash;
		private string unlockPUDetailText;
		private bool isParentLayer;
		private CellLockStatus cellLockStatue;
	
		// Properties
		public QuestSelectInstance.QuestEventData getCurEventData { get; }
		protected FlashPlayerManager flashPlayerManager { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum CellLockStatus
		{
			Open = 0,
			NeedQuestClear = 1,
			NotOpenPeriod = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public EventMenuCell __4__this;
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _ShowNextEventSchedulePopup_b__0();
			internal void _ShowNextEventSchedulePopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public QuestEventGroupElement groupElement;
			public QuestEventElement cellEventElement;
			public Action changePage;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal void _OnNormalEventMenuCellTouched_b__0();
			internal void _OnNormalEventMenuCellTouched_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__55_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnNormalEventMenuCellTouched_b__55_2();
		}
	
		// Constructors
		public EventMenuCell();
		static EventMenuCell();
	
		// Methods
		private void Awake();
		public virtual void SetContent(QuestEventGroupElement groupElement, bool isShowArrow, FlashPlayerManager flashPlayerManager, bool isParentLayer = false, bool isViewNewBadge = false, QuestSupportCanvas.PlayType playType = QuestSupportCanvas.PlayType.both);
		public bool IsSameGroup(QuestEventGroupElement groupElement);
		public void SetCampaignIcon(QuestSupportCanvas.PlayType playType);
		protected void SetBonusInformation(QuestEventElement eventElement);
		private void SetBonusBoxes(int openedCount, int maxCount, QuestResetIntervalType bonusType);
		public virtual void SetContent(QuestSelectInstance.QuestEventData eventData, bool isShowArrow, FlashPlayerManager flashPlayerManager);
		private QuestUtil.QuestState GetQuestState(QuestEventGroupElement eventGroup);
		protected void SetQuestStateIcon(QuestUtil.QuestState state);
		private static void SetActiveScale(GameObject obj, bool isActive);
		private void SetContentCommon(int id, bool isShowArrow, int eventGroupId);
		private void SetUnlockInfo(int eventId, int eventGroupId);
		private void SetEventTutorialLockText();
		private void ShowNextEventSchedulePopup();
		public static void OnNormalEventMenuCellTouched(QuestEventGroupElement groupElement, QuestSelectInstance.QuestEventData curEventData);
		public virtual void OnCellTouched();
		public override bool SetGradientShader();
		public void UpdateRemainTime();
		[CompilerGenerated]
		private void _SetContentCommon_b__51_0(Material mat);
	}
}
