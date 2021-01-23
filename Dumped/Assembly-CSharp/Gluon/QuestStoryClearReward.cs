/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestStoryClearReward : MonoBehaviour
	{
		// Fields
		private Action OnEnded;
		private bool hasItemReward;
		private bool hasFacilityReward;
		private int facilityPlantId;
		private bool isEvent;
		private Transform parentTransform;
		public FlashPlayerManager flashMgr;
		public Action<int, GiftType, int, Action> onNewEnrollmentPopup;
	
		// Properties
		public bool isEventEnable { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public QuestStoryClearReward __4__this;
			public int startIndex;
	
			// Constructors
			public __c__DisplayClass12_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1
		{
			// Fields
			public QuestResultModel.FirstClearModel.FirstClearItemInfo info;
			public __c__DisplayClass12_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass12_1();
	
			// Methods
			internal void _ShowNextCharaDragonRewardPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public QuestStoryClearReward __4__this;
			public AtgenQuestStoryRewardList reward;
			public int startIndex;
			public Action checkDuplicate;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _CharaDragonPopupCreate_b__0();
			internal void _CharaDragonPopupCreate_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_1
		{
			// Fields
			public PopupBase duplicatePopup;
			public __c__DisplayClass13_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass13_1();
	
			// Methods
			internal void _CharaDragonPopupCreate_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public PopupBase duplicatePopup;
			public QuestStoryClearReward __4__this;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _CheckDuplicateItem_b__0();
		}
	
		// Constructors
		public QuestStoryClearReward();
	
		// Methods
		private void Start();
		public void CheckStoryReward(bool isEvent, Transform parentTransform = null, Action OnEnded = null, bool isFirstTime = false);
		private void ShowNextCharaDragonRewardPopup(int startIndex);
		public void CharaDragonPopupCreate(QuestResultModel.FirstClearModel.FirstClearItemInfo info, int startIndex);
		private void ShowItemRewardPopup();
		private void ShowFacilityRewardPopup();
		private void CheckDuplicateItem();
		private void OnBeforeLeaving(bool clearStoryRewardList = true);
		private PopupBase CheckStoryRewardDuplicate(int id, GiftType type);
		private PopupBase CheckStoryRewardListDuplicateList();
		private void CheckRaidChara();
		private bool IsExistCharaInQuestStoryReward();
		[CompilerGenerated]
		private void _ShowItemRewardPopup_b__14_0();
		[CompilerGenerated]
		private void _ShowFacilityRewardPopup_b__15_0();
	}
}
