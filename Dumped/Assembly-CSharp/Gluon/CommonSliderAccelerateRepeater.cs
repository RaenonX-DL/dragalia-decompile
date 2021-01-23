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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonSliderAccelerateRepeater : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CommonSliderSelection sliderSelection;
		[SerializeField]
		private PointerEventHandler plusButtonEventHandler;
		[SerializeField]
		private PointerEventHandler minusButtonEventHandler;
		[SerializeField]
		private float touchDurationDefault;
		[SerializeField]
		private float touchDurationMin;
		[SerializeField]
		private int longPressAddValueMax;
		[SerializeField]
		private int longPressAddSpeed;
		private int longPressAddValue;
		private Coroutine countCoroutine;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public CommonSliderAccelerateRepeater __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CommonSliderAccelerateRepeater();
	
		// Methods
		private void Start();
		public void UseCountButtonPressed(int countInc);
		public void UseCountButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		public void OnSliderValueChanged(float val);
		private void LongPressEnded();
		[CompilerGenerated]
		private void _Start_b__9_0(float value);
		[CompilerGenerated]
		private void _Start_b__9_1(PointerEventData data);
		[CompilerGenerated]
		private void _Start_b__9_2(PointerEventData data);
	}
}
