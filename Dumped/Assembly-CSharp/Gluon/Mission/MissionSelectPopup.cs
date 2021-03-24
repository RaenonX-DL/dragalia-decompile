/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Mission
{
	public class MissionSelectPopup : MissionSelectPopupBase
	{
		// Fields
		private static readonly List<TabCategory> enableTabCategories;
		private static TabCategory _selectMissionCategory;
		[SerializeField]
		private Image pickupBadge;
		public Button toShopButton;
		public UnityEngine.UI.Text toShopButtonText;
		[SerializeField]
		protected UnityEngine.UI.Text switchHistoryText;
		protected bool isShowHistory;
	
		// Properties
		public static TabCategory selectMissionCategory { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public Action<MissionSelectPopup> onComplete;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public MissionSelectPopup();
		static MissionSelectPopup();
	
		// Methods
		private static int ConvertCategoryToIndex(TabCategory category);
		private static TabCategory ConvertIndexToCategory(int index);
		protected override void UpdateBadge();
		public static bool ShouldEnableMissionBadge();
		private static MissionSelectPopup CreateSub(Size size = Size.L, BottomButtons bottomButtons = BottomButtons.CancelOk, bool showBlackLayer = true, bool showStartAnimation = true);
		public static void Create(Action<MissionSelectPopup> onComplete = null);
		protected override void Start();
		protected override TabCategory GetSelectedMissionCategory();
		protected override void SetVisibleNoCellEntry(bool isNoEntry);
		public override void InitializeTabButton();
		protected override void InitializeMissionTab();
		public override void ReloadData();
		public void OnSwitchHistoryButtonPressed();
		protected override void SetCellDatas();
		public override void ReloadWithRequestGetList();
		[CompilerGenerated]
		private void _InitializeTabButton_b__19_0(int index);
	}
}
