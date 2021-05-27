/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManagedFacilityDialogController : PopupBase
	{
		// Fields
		[SerializeField]
		private TabViewBase tabView;
		[SerializeField]
		private Transform sortParentTransform;
		[CompilerGenerated]
		private Canvas _canvas_k__BackingField;
		[CompilerGenerated]
		private GameObject _fortRoot_k__BackingField;
		private List<ManagedFacilityController> managedFacilityCtrlList;
		private CommonSortButton sortButton;
		private FlashPlayer managedFacilityFlashPlayer;
		private ManagedFacilityCell selectedCell;
		private PopupCanvas popupCanvasComponent;
		private static List<string> managedFacilityTabNameList;
	
		// Properties
		public Canvas canvas { [CompilerGenerated] get; [CompilerGenerated] set; }
		public GameObject fortRoot { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ExecutedFacilityAction
		{
			Store = 0,
			LevelUp = 1,
			CompleteBuilding = 2,
			ExchangeMaterial = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public ManagedFacilityController curerntTabCtr;
			public ManagedFacilityDialogController __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _OnSortButtonClicked_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public Facility facility;
			public FacilityViewController facilityVC;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _StoreFacility_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public ManagedFacilityDialogController __4__this;
			public Facility nextFacility;
			public Facility currentFacility;
			public FacilityViewController facilityVC;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _LevelUpFacility_b__1(Facility facility);
			internal void _LevelUpFacility_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__25_3;
			public static UnityAction __9__25_0;
			public static UnityAction __9__26_0;
			public static Action __9__27_0;
			public static ExecuteEvents.EventFunction<FortUIEventInterface> __9__29_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _LevelUpFacility_b__25_3(FortUIEventInterface reciever, BaseEventData eventData);
			internal void _LevelUpFacility_b__25_0();
			internal void _CompleteAtOnceFacility_b__26_0();
			internal void _ShowFacilityInformation_b__27_0();
			internal void _OnFalicitySelectCofirm_b__29_0(FortUIEventInterface reciever, BaseEventData eventData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public ManagedFacilityDialogController __4__this;
			public ExecutedFacilityAction executedFacilityAction;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _UpdateCurrentContents_b__0();
			internal void _UpdateCurrentContents_b__1();
		}
	
		// Constructors
		public ManagedFacilityDialogController();
	
		// Methods
		private void Awake();
		protected override void Start();
		private void OnSortButtonClicked();
		public void OnCloseButtonPressd();
		public void SetActiveSortButton(bool isActive);
		private void SetManagedFacilityFlashPlayer(string flashPath, Transform target);
		private void UpdateSortAndFilter(int tabIndex);
		public void StoreFacility(Facility facility);
		public void LevelUpFacility(Facility currentFacility);
		public void CompleteAtOnceFacility(Facility facility);
		public void ShowFacilityInformation(Facility facility);
		public void SetSelectedCell(ManagedFacilityCell selectedCell);
		public void OnFalicitySelectCofirm(Facility facility);
		public void UpdateCurrentContents(ExecutedFacilityAction executedFacilityAction);
		public static void ResetTabSetting();
		private void RegisterTabNameList();
		[CompilerGenerated]
		private void _Start_b__18_0(int curIndex, int previousIndex);
	}
}
