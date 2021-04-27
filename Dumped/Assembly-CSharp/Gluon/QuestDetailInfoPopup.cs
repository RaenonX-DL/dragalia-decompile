/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestDetailInfoPopup : CommonPopup
	{
		// Fields
		public ButtonSprite[] missionClearButtons;
		public GameObject missionDetailNode;
		public UnityEngine.UI.Text[] missionTexts;
		public Image elementImageIndex;
		public Image element2ImageIndex;
		public Image elementImageSimple;
		public Image element2ImageSimple;
		public QuestDifficultyImageSetter difficultyImageSetter;
		public UnityEngine.UI.Text uiQuestIndex;
		public UnityEngine.UI.Text uiTitleIndex;
		public UnityEngine.UI.Text uiTitleSimple;
		public GameObject uiTitleSimpleRoot;
		public UnityEngine.UI.Text uiClearCondition;
		public UnityEngine.UI.Text uiLoseCondition;
		public UnityEngine.UI.Text uiRebornCondition;
		public GameObject specialRuleObject;
		public GameObject specialRule2Object;
		public GameObject uiTreasure;
		public UnityEngine.UI.Text uiTreasureText;
		[SerializeField]
		private UnityEngine.UI.Text uiRewardCautionText;
		public GameObject uiTreasureNode;
		public GameObject uiBouns;
		public UnityEngine.UI.Text uiBounsText;
		public GameObject uiBounsNode;
		public GameObject uiDiscover;
		public UnityEngine.UI.Text uiDiscoverText;
		public GameObject uiDiscoverNode;
		public GameObject uiDragonSpher;
		public GameObject uiDragonSpherNode;
		public GameObject uiMissionReward;
		public UnityEngine.UI.Text uiMissionRewardText;
		public GameObject uiMissionRewardNode;
		public GameObject uiMissionCompleteReward;
		public UnityEngine.UI.Text uiMissionCompleteRewardText;
		public GameObject uiMissionCompleteRewardNode;
		public GameObject uiFirstClearReward;
		public UnityEngine.UI.Text uiFirstClearRewardText;
		public GameObject uiFirstClearRewardNode;
		public GameObject uiQuestCarryReward;
		public UnityEngine.UI.Text uiQuestCarryRewardText;
		public GameObject uiQuestCarryRewardNode;
		[SerializeField]
		private GameObject guestImage;
		[SerializeField]
		protected Image recommendedPowerIcon;
		[SerializeField]
		protected Image necessaryPowerIcon;
		[SerializeField]
		protected Image questPowerValueBackGround;
		[SerializeField]
		private UnityEngine.UI.Text uiPowerText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text questDetailTitle;
		[SerializeField]
		private UnityEngine.UI.Text clearConditionTitle;
		[SerializeField]
		private UnityEngine.UI.Text failureConditionTitle;
		[SerializeField]
		private UnityEngine.UI.Text missionDetailTitle;
		[SerializeField]
		private UnityEngine.UI.Text treasureTitle;
		[SerializeField]
		private UnityEngine.UI.Text discoverTitle;
		[SerializeField]
		private UnityEngine.UI.Text dailyTitle;
		[SerializeField]
		private UnityEngine.UI.Text missionRewardTitle;
		[SerializeField]
		private UnityEngine.UI.Text missionCompleteRewardTitle;
		[SerializeField]
		private UnityEngine.UI.Text firstClearRewardTitle;
		[Header]
		[SerializeField]
		private GameObject[] rebornSections;
		[SerializeField]
		private UnityEngine.UI.Text[] rebornTitles;
		[SerializeField]
		private Transform[] rebornRewardParents;
		[Header]
		[SerializeField]
		private GameObject abnormalStatusTitleNode;
		[SerializeField]
		private GameObject abnormalStatusNode;
		[SerializeField]
		private GameObject abnormalStatusCell;
		[SerializeField]
		private GameObject effectiveAbnormalStatusTitleNode;
		[SerializeField]
		private GameObject effectiveAbnormalStatusNode;
		[SerializeField]
		private GameObject effectiveAbnormalStatusCell;
		[Header]
		[SerializeField]
		private Image specialTopImage;
		[SerializeField]
		private CommonScrollRect commonScrollRect;
		[CompilerGenerated]
		private int _curQuestId_k__BackingField;
		[CompilerGenerated]
		private bool _IsQuestWall_k__BackingField;
		private const float waitRenderTime = 0.1f;
		private ButtonSound buttonSound;
		private static UnityAction onUnitDetailModelCreated;
		private static UnityAction onUnitDetailModelBackButtonClicked;
	
		// Properties
		public int curQuestId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsQuestWall { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public class SortAbnormal
		{
			// Fields
			public AbnormalStatusType type;
			public int registAbnormalRate;
			public int sortId;
	
			// Constructors
			public SortAbnormal();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public QuestDataElement qde;
			public QuestDetailInfoPopup __4__this;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _ReflectQuestMenuParam_b__0(Material mat);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<EntityData, int> __9__85_0;
			public static Func<EntityData, QuestResultModel.TopPageModel.RewardItemInfo.PorchRarity> __9__85_2;
			public static Func<EntityData, int> __9__85_3;
			public static Func<EntityData, int> __9__85_4;
			public static Func<EntityData, bool> __9__88_0;
			public static Func<SortAbnormal, int> __9__91_1;
			public static Func<SortAbnormal, int> __9__91_2;
			public static Func<EntityData, bool> __9__91_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SortRewardData_b__85_0(EntityData rec);
			internal QuestResultModel.TopPageModel.RewardItemInfo.PorchRarity _SortRewardData_b__85_2(EntityData rec);
			internal int _SortRewardData_b__85_3(EntityData rec);
			internal int _SortRewardData_b__85_4(EntityData rec);
			internal bool _ReflectRewardData_b__88_0(EntityData treasure);
			internal int _ReflectRewardDataQuestWall_b__91_1(SortAbnormal p);
			internal int _ReflectRewardDataQuestWall_b__91_2(SortAbnormal p);
			internal bool _ReflectRewardDataQuestWall_b__91_0(EntityData treasure);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass97_0
		{
			// Fields
			public QuestDetailInfoPopup __4__this;
			public QuestMissionDetailPopup missionDetail;
	
			// Constructors
			public __c__DisplayClass97_0();
	
			// Methods
			internal void _OnMissionButtonClicked_b__0();
		}
	
		// Constructors
		public QuestDetailInfoPopup();
		static QuestDetailInfoPopup();
	
		// Methods
		public static QuestDetailInfoPopup Create(int questID, string qusetIndex, QuestSelectScene.Difficulty difficulty, UnityAction OnCloseCallback, bool showBlackLayer = true);
		public void GetButtonSound();
		private void SetButtonSoundAction(PointerEventHandler eventHandler);
		public void SetItemTitleTexts(int questId);
		public void ReflectQuestMenuParam(int questID);
		public void ReflectQuestMenuParamQuestWall(int wallId);
		private List<EntityData> SortRewardData(List<EntityData> list);
		private int GetMaterialPriority(EntityData rewardData);
		public void InitDropList();
		private void ReflectRewardData(int questId);
		private void SetCommonIconButtonSound(CommonIcon icon, ButtonSound.SEType sEType);
		private void ReflectRewardDataQuestWall(int wallId);
		private void SetupIcon(EntityData ed, Transform parent, bool hadGot);
		private void SetIconListenerOnClickAndOnLongClick(CommonIcon icon);
		private void RequestAvailableDropList(int questID);
		private void OnSuccessQuestDropList(QuestDropListResponse res);
		public override void OnCloseButtonPressed();
		public void OnMissionButtonClicked();
		public void SetEnabled(Image image, Button button, bool isEnabled);
		public void SetPopupCanvasActive(bool value);
		public void ReOpen();
		private void InitGuest(int questId);
		private bool IsZeshiaReleasePoint(int charaId);
		[CompilerGenerated]
		private int _SortRewardData_b__85_1(EntityData rec);
	}
}
