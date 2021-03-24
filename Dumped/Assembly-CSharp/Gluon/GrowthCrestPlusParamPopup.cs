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
	public class GrowthCrestPlusParamPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text hpItemName;
		public UnityEngine.UI.Text atkItemName;
		public Image hpItemIcon;
		public Image atkItemIcon;
		public CommonSlider hpItemSlider;
		public CommonSlider atkItemSlider;
		public Button hpPlusButton;
		public Button hpMinusButton;
		public Button atkPlusButton;
		public Button atkMinusButton;
		public UnityEngine.UI.Text hpUseCountText;
		public UnityEngine.UI.Text hpTotalCountText;
		public UnityEngine.UI.Text atkUseCountText;
		public UnityEngine.UI.Text atkTotalCountText;
		public GameObject[] hpPlusUIObjects;
		public GameObject[] atkPlusUIObjects;
		private int _nowHPValue;
		private int maxHPValue;
		private int _nowAtkValue;
		private int maxAtkValue;
		private GrowthUnitEnhanceModel model;
		private Coroutine countCoroutine;
		private PointerEventHandler hpPlusButtonEventHandler;
		private PointerEventHandler hpMinusButtonEventHandler;
		private PointerEventHandler atkPlusButtonEventHandler;
		private PointerEventHandler atkMinusButtonEventHandler;
		private int hpItemId;
		private int atkItemId;
		private int oldSliderHpValue;
		private int oldSliderAtkValue;
	
		// Properties
		public int nowHPValue { get; private set; }
		public int nowAtkValue { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public bool isAtkSlider;
			public GrowthCrestPlusParamPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthCrestPlusParamPopup();
	
		// Methods
		public static GrowthCrestPlusParamPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public void OnChangeHPSliderValue(float newValue);
		public void OnChangeAtkSliderValue(float newValue);
		public void OnHpPlusButtonPressed();
		public void OnHpMinusButtonPressed();
		public void OnAtkPlusButtonPressed();
		public void OnAtkMinusButtonPressed();
		public Dictionary<int, int> GetUseMaterial();
		private void InitHpSlider();
		private void InitAtkSlider();
		private void UpdateOkButtonState();
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isAtkSlider, bool isPlus);
		[CompilerGenerated]
		private void _InitHpSlider_b__45_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitHpSlider_b__45_1(PointerEventData data);
		[CompilerGenerated]
		private void _InitAtkSlider_b__46_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitAtkSlider_b__46_1(PointerEventData data);
	}
}
