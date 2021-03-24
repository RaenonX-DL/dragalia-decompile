/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftStepupConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public UnityEngine.UI.Text message;
		public CraftMaterialCell originCell;
		public UnityEngine.UI.Text totalExp;
		public UnityEngine.UI.Text totalCoin;
		public UnityEngine.UI.Text breforeCoin;
		public UnityEngine.UI.Text afterCoin;
		public UnityEngine.UI.Text craftCount;
		public UnityEngine.UI.Text craftMaxCount;
		public Slider craftSlider;
		public UnityEngine.UI.Text selectWeaponMessage;
		[HideInInspector]
		public int totalCraftCount;
		[HideInInspector]
		public int targetId;
		[HideInInspector]
		public Dictionary<int, int> allMaterialDict;
		public GameObject sliberBase;
		public UnityEngine.UI.Text errorMessage;
		public List<CraftMaterialCell> materialCellList;
		public List<CraftMaterialCell> materialWeaponCellList;
		public GameObject autoLimitBreakBase;
		public GameObject autoLimitBreakSpace;
		public Toggle autoLimitBreakToggle;
		public Transform cellParent;
		[CompilerGenerated]
		private bool _isItemUpdate_k__BackingField;
		public Button plusButton;
		public Button minusButton;
		public Action materialReloadCallBack;
		public Action<CraftStepupConfirmPopupBackupData> createMaterialWeaponCallBack;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private Coroutine countCoroutine;
		private int assembleCoin;
		[HideInInspector]
		private CaftNeedMaterialData needMaterialData;
		private bool isMuteSliderSe;
		private Dictionary<int, CraftMaterialCellData> craftMaterialWeaponCellDatas;
		private bool isEnableCraft;
		private int defaultCraftCount;
		private int showMaterialWeaponPopupSetId;
		private ulong[] materialWeaponPopupSelectKeyIds;
		private bool isFirstStepCraft;
	
		// Properties
		public bool isItemUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<KeyValuePair<int, int>, int> __9__44_0;
			public static Func<KeyValuePair<int, int>, int> __9__44_1;
			public static Func<KeyValuePair<int, int>, int> __9__46_0;
			public static Func<KeyValuePair<int, int>, int> __9__46_1;
			public static Predicate<ulong> __9__52_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _UpdatePopup_b__44_0(KeyValuePair<int, int> pair);
			internal int _UpdatePopup_b__44_1(KeyValuePair<int, int> pair);
			internal int _UpdateMaterialInfo_b__46_0(KeyValuePair<int, int> pair);
			internal int _UpdateMaterialInfo_b__46_1(KeyValuePair<int, int> pair);
			internal bool _DeleteLockedWeaponKeyId_b__52_0(ulong keyId);
		}
	
		[CompilerGenerated]
		private sealed class _SliderSeActiveDelay_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftStepupConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SliderSeActiveDelay_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public CraftStepupConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public CraftStepupConfirmPopup __4__this;
			public CraftMaterialCellData cellData;
	
			// Constructors
			public __c__DisplayClass51_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_1
		{
			// Fields
			public CraftMaterialWeaponSelectPopup popup;
			public __c__DisplayClass51_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass51_1();
	
			// Methods
			internal void _OnMaterialIconPressed_b__0(int weaponId);
			internal void _OnMaterialIconPressed_b__1();
			internal void _OnMaterialIconPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public CommonPopup popup;
			public Action popupCallBack;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _ShowNoDismantlePopup_b__0();
			internal void _ShowNoDismantlePopup_b__1();
		}
	
		// Constructors
		public CraftStepupConfirmPopup();
	
		// Methods
		public static CraftStepupConfirmPopup Create();
		protected override void Start();
		public void InitPop(int weaponId, CraftStepupConfirmPopupBackupData backupData = null);
		private void UpdatePopup();
		[IteratorStateMachine]
		private IEnumerator SliderSeActiveDelay();
		private void UpdateMaterialInfo();
		public void SliderValueChanged();
		public void OnValueChangeButtonPressed(int value);
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		private void DeleteLockedWeaponKeyId(ref ulong[] materialKeys);
		private void UpdateCraftButton();
		public override void OnOkButtonPressed();
		public override void OnCancelButtonPressed();
		private void OnEnable();
		private void OnDisable();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		public CraftStepupSendData GetSendData();
		public ulong[] GetUseMaterialWeaponKeyIds();
		public static void ShowNoDismantlePopup(Action popupCallBack);
		[CompilerGenerated]
		private void _Start_b__42_0(PointerEventData data);
		[CompilerGenerated]
		private void _Start_b__42_1(PointerEventData data);
	}
}
