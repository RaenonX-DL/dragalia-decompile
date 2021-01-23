/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ItemMaterialCell : TableViewCell<Gluon.ItemMaterialCellData>
	{
		// Fields
		public Image itemIcon;
		public UnityEngine.UI.Text itemNameText;
		public UnityEngine.UI.Text useCountText;
		public UnityEngine.UI.Text maxCountText;
		public Slider useCountSlider;
		public Button plusButton;
		public Button minusButton;
		public Image plusButtonIcon;
		public Image minusButtonIcon;
		public Sprite buttonEnableIcon;
		public Sprite buttonDisableIcon;
		public UnityAction longPressCallBack;
		public UnityAction longPressEndCallBack;
		public Image cellLockImage;
		[SerializeField]
		public UnityAction<int> buttonPressed;
		[SerializeField]
		public MaterialSliderUpdateEvent sliderUpdate;
		private int materialId;
		private int useItemCount;
		private int maxUseCount;
		private bool maxExpFlg;
		private bool isNotUpdateSlider;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private Coroutine countCoroutine;
		private bool isScrollLock;
		private ItemMaterialCellData cellData;
		private GameObject lockButtonObj;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public ItemMaterialCell __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public ItemMaterialCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(ItemMaterialCellData data);
		public void UseCountButtonPressed(int countInc);
		public void UseCountButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		public void SliderValueChanged();
		public void OnButtonPressed();
		public void UpdateItemCountButton();
		private void LongPressEnded();
		[CompilerGenerated]
		private void _Start_b__27_0(PointerEventData data);
		[CompilerGenerated]
		private void _Start_b__27_1(PointerEventData data);
	}
}
