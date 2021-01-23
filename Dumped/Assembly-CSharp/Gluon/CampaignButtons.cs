/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CampaignButtons : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public PointerEventHandler[] campaignButtons;
		[SerializeField]
		private UnityEngine.UI.Text[] campaignButtonText;
		[SerializeField]
		private GridLayoutGroup gridLayoutGroup;
		private Vector2 campaignPosOne;
		private Vector2 campaignPos;
		private CampaignDataWrapper[] campaignData;
		private List<CampaignDataWrapper> campaignDataList;
		private bool isVoidBattle;
	
		// Nested types
		public enum CampaignButtonsEnumType
		{
			BannerType = 0,
			CellType = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<QuestScheduleDataWrapper, bool> __9__16_0;
			public static Func<QuestScheduleDataWrapper, bool> __9__16_1;
			public static Func<QuestScheduleDataWrapper, bool> __9__18_0;
			public static Func<CampaignDataWrapper, bool> __9__19_5;
			public static Func<QuestScheduleDataWrapper, bool> __9__19_6;
			public static Func<CampaignDataWrapper, bool> __9__20_0;
			public static Func<QuestScheduleDataWrapper, bool> __9__20_1;
			public static Comparison<CampaignDataWrapper> __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _MayCampaignAvailable_b__16_0(QuestScheduleDataWrapper e);
			internal bool _MayCampaignAvailable_b__16_1(QuestScheduleDataWrapper e);
			internal bool _MayCampaignAvailableByQuestId_b__18_0(QuestScheduleDataWrapper e);
			internal bool _GetCampaignData_b__19_5(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__19_6(QuestScheduleDataWrapper e);
			internal bool _GetCampaignData_b__20_0(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__20_1(QuestScheduleDataWrapper e);
			internal int _ShowCampaigns_b__21_0(CampaignDataWrapper elem1, CampaignDataWrapper elem2);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public CampaignDataElement withInDecreaseCampaign;
			public CampaignDataElement withInDecreaseCampaignMulti;
			public CampaignDataElement withInManaUpCampaign;
			public CampaignDataElement withInCoinUpCampaign;
			public CampaignDataElement withInItemDropUpCampaign;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal bool _GetCampaignData_b__0(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__1(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__2(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__3(CampaignDataWrapper campaignData);
			internal bool _GetCampaignData_b__4(CampaignDataWrapper campaignData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public CampaignPopup popup;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _CreateCampaignPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public CampaignButtons __4__this;
			public CampaignListQuestGroupPopup popup;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _OnClickCampaignButton_b__0();
			internal void _OnClickCampaignButton_b__1();
		}
	
		// Constructors
		public CampaignButtons();
	
		// Methods
		public void Initialize(int groupId, CampaignButtonsEnumType type);
		public void Initialize(QuestSelectInstance.QuestEventData eventData, CampaignButtonsEnumType type);
		public void Initialize(int groupId, bool isSoloMultiParent = false);
		public void Initialize(QuestDataElement questData, CampaignButtonsEnumType type);
		public void Initialize(QuestSelectInstance.QuestEventData eventData);
		public void HideCampaign(CampaignButtonsEnumType type);
		public static bool MayCampaignAvailable(QuestSelectInstance.QuestEventData eventData, bool useOnlyLegacyData = false);
		public static bool MayCampaignAvailable(int groupId, bool useOnlyLegacyData = false);
		public static QuestSupportCanvas.PlayType GetPlayType(int groupId);
		public static bool MayCampaignAvailableByQuestId(int questId);
		private void GetCampaignData(int groupId, Queue<CampaignDataWrapper> campaignTypeQueue, bool isSoloMultiParent = false);
		private void GetCampaignData(QuestDataElement questData, Queue<CampaignDataWrapper> campaignTypeQueue);
		private void ShowCampaigns(CampaignButtonsEnumType type, Queue<CampaignDataWrapper> campaignTypeQueue);
		private void SetButton(PointerEventHandler peh, UnityEngine.UI.Text text, CampaignDataWrapper data);
		public void OnDecreaseStaminaSingle();
		public void OnRecoveryDoubleStaminaSingle();
		public void OnDecreaseStaminaMulti();
		public void OnRecoveryDoubleStaminaMulti();
		public void OnManaUp();
		public void OnCoinUp();
		public void OnItemDropUp();
		public void OnItemDropUpSingle();
		public void OnItemDropUpMulti();
		private void CreateCampaignPopup(CampaignType type);
		public void OnClickCampaignButton();
	}
}
