/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyEquipCrestSelectPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private GameObject type1Slot;
		[SerializeField]
		private GameObject type2Slot;
		[SerializeField]
		private Image crestIcon;
		[SerializeField]
		private CommonUnionIcon crestUnionIcon;
		[SerializeField]
		private UnityEngine.UI.Text releaseCount;
		[SerializeField]
		private UnityEngine.UI.Text ability;
		[SerializeField]
		private Image unionIcon;
		[SerializeField]
		private GameObject emptyObject;
		[SerializeField]
		private GameObject crestInfoObject;
		[SerializeField]
		private UnityEngine.UI.Text listSwitchButtonText;
		[SerializeField]
		private Image emptyIcon;
		[SerializeField]
		private GameObject outButtonOject;
		[SerializeField]
		private GameObject noneUnionGameObject;
		[SerializeField]
		private GameObject eventBonusObject;
		[SerializeField]
		private EquipUnitListController equipUnitListController;
		[SerializeField]
		private CommonIconListBase iconListBase;
		private int crestId;
		private AblitiyCrestSlotType slotType;
		private int slotIndex;
		private bool isSupportFriend;
		private int selectedCrestId;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public CommonIconListCellData data;
			public PartyEquipCrestSelectPopup __4__this;
			public CommonEquipIconCellData equipData;
	
			// Constructors
			public __c__DisplayClass24_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_1
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass24_1();
	
			// Methods
			internal void _OnIconButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_2
		{
			// Fields
			public PartyEquipOverPopup popup;
			public __c__DisplayClass24_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass24_2();
	
			// Methods
			internal void _OnIconButtonPressed_b__1();
			internal void _OnIconButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_3
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass24_3();
	
			// Methods
			internal bool _OnIconButtonPressed_b__3(PartySettingList e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public PartyEquipCrestSelectPopup __4__this;
			public CommonEquipIconCellData equipData;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _OnIconButtonLongPressed_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CommonListCustomSortData, CommonListCustomSortData> __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal CommonListCustomSortData _InitList_b__29_0(CommonListCustomSortData data);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public ulong equippedId;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal bool _InsertActiveEquipmentToFilteredList_b__0(ulong id);
		}
	
		// Constructors
		public PartyEquipCrestSelectPopup();
	
		// Methods
		public static PartyEquipCrestSelectPopup Create();
		public void Setup(int slotIndex, int slotType, int crestId, bool isSupportFriend = false);
		private void RefreshEquippedCrest();
		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void SelectEquipUnit(CommonEquipIconCellData equipData);
		private void SelectEquipIconCellData(ulong keyId, CommonEquipIconCellData equipData, bool hasOutButtonSelectState);
		private void OnIconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		public void OnOutButtonPressed();
		private void InitList();
		private void SetupSlot(int slotType);
		private void OnSortButtonClicked();
		private List<ulong> InsertActiveEquipmentToFilteredList(List<ulong> filteredList);
		public void OnListChangeButtonPressed();
		public int GetSelectedCrestId();
	}
}
