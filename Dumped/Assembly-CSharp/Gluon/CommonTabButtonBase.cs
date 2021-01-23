/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class CommonTabButtonBase : MonoBehaviour
	{
		// Fields
		private PointerEventHandler eventHandler;
		private Button button;
		private Color onTextColor;
		private Color offTextColor;
		private Animator buttonAnimator;
		private bool bDisabled;
		[SerializeField]
		private UnityEngine.UI.Text[] texts;
		private int index;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Action<int, bool> callback;
			public CommonTabButtonBase __4__this;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _AddCallback_b__0();
		}
	
		// Constructors
		public CommonTabButtonBase();
	
		// Methods
		public void Awake();
		private void TryGetComponents();
		public void SetIndex(int index);
		public void SetOnOffSprites(Sprite onSprite, Sprite offSprite);
		public void SetTextColors(Color onColor, Color offColor);
		public void AddCallback(Action<int, bool> callback);
		public void SwitchTextColor(bool on);
		public void SetOnOffState(bool on);
		public void DisableButton(bool disabled);
		[CompilerGenerated]
		private void _Awake_b__8_0(PointerEventData PointerEventData);
		[CompilerGenerated]
		private void _Awake_b__8_1(PointerEventData PointerEventData);
		[CompilerGenerated]
		private void _Awake_b__8_2(PointerEventData PointerEventData);
	}
}
