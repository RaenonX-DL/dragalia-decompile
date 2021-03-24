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
	public class GrowthUnitEquipCountConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public CommonSlider slider;
		public Button plusButton;
		public Button minusButton;
		public UnityEngine.UI.Text useCountText;
		public UnityEngine.UI.Text totalCountText;
		public UnityEngine.UI.Text conditionText;
		public GameObject[] dewUIObjects;
		public UnityEngine.UI.Text needDewText;
		public UnityEngine.UI.Text beforeDewText;
		public UnityEngine.UI.Text afterDewText;
		public UnityEngine.UI.Text shortDewText;
		public GameObject[] materialUIObjects;
		public GameObject rupiUIObject;
		public Image equipIcon;
		public Sprite weaponIconSprite;
		public Material weaponIconMaterial;
		public Sprite crestIconSprite;
		public Material crestIconMaterial;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		private int _nowValue;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private Coroutine updateUICoroutine;
		private Coroutine countCoroutine;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private int minValue;
		private int maxValue;
		private bool isDesabledReleaseButton;
		private bool isShortageRupi;
		private bool isEndInitTask;
		private bool isSkipChangeValueTask;
		private PointerEventHandler okButtonHandler;
	
		// Properties
		public int nowValue { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public GrowthUnitEquipCountConfirmPopup __4__this;
	
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
		private sealed class _UpdatePopupUIDelay_d__51 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthUnitEquipCountConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdatePopupUIDelay_d__51(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthUnitEquipCountConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthUnitEquipCountConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public void ChangedSliderValue(float newValue);
		public void OnPlusButtonPressed();
		public void OnMinusButtonPressed();
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		[IteratorStateMachine]
		private IEnumerator UpdatePopupUIDelay();
		private void UpdatePopupUI();
		private void SetupMaterialCell();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		private void SetupRupi();
		private void UpdateRupi();
		private void SetupDewUI();
		private void UpdateDewUI();
		private void InitReleaseCountSlider();
		private void SetEquiplIcon();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _InitReleaseCountSlider_b__60_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitReleaseCountSlider_b__60_1(PointerEventData data);
	}
}
