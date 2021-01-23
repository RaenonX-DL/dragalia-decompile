/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventExchangePage : EventQuestPageBase
	{
		// Fields
		[SerializeField]
		private Transform exchangeTrans;
		[SerializeField]
		private Image logoImage;
		[SerializeField]
		private float topMargin;
		[SerializeField]
		private UnityEngine.UI.Text durationText;
		public Transform edgeToEdgeTransform;
		private ShopTradeEventTradeShopView tradeShop;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitforLoadShopTradeEventTradeShopView_d__10 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EventExchangePage __4__this;
			public AnimationUICanvas.AnimationPattern pattern;
			public Action onAnimationDone;
			public Action onCutOff;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitforLoadShopTradeEventTradeShopView_d__10(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public EventExchangePage();
	
		// Methods
		private void Start();
		public override void OnPageBecomeActive(object data);
		public override void OnPageEnterAnimationEnded();
		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[IteratorStateMachine]
		private IEnumerator WaitforLoadShopTradeEventTradeShopView(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		public void OnBackButtonTouched();
		[CompilerGenerated]
		private void _Start_b__6_0();
		[CompilerGenerated]
		private bool _WaitforLoadShopTradeEventTradeShopView_b__10_0();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0(AnimationPattern pattern, Action onAnimationDone, Action onCutOff);
	}
}
