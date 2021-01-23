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
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestElementConfirmPopup : CommonPopup
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/QuestElementConfirmPopup";
		[SerializeField]
		private GameObject lackOfPowerText;
		[SerializeField]
		private UnityEngine.UI.Text popupText;
		[SerializeField]
		private Image currentElementIcon;
		[SerializeField]
		private UnityEngine.UI.Text currentElementText;
		[SerializeField]
		private LocalizeTextLayoutPadding currentElementTextPadding;
		[SerializeField]
		private Image superiorElementIcon;
		[SerializeField]
		private UnityEngine.UI.Text superiorElementText;
		[SerializeField]
		private Toggle noReshowPopupCheckbox;
		private string currentElementStr;
		private const string FormatIconTagText = "{0}";
		private const string FormatIconTagReplaceText = "    ";
		private const string FormatIconTagReplaceText_ZH_TW = "     ";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public QuestElementConfirmPopup __4__this;
			public UnityAction cancelCallback;
			public UnityAction okCallaback;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _Initialize_b__0();
			internal void _Initialize_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _SetElementTextWithIconImage_d__16 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string orgStr;
			public QuestElementConfirmPopup __4__this;
			public Image icon;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetElementTextWithIconImage_d__16(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestElementConfirmPopup();
	
		// Methods
		public static QuestElementConfirmPopup Create();
		public void Initialize(ElementalType superiorElementType, ElementalType currentElementType, bool isLackOfPower, UnityAction cancelCallback, UnityAction okCallaback);
		private new void Start();
		[IteratorStateMachine]
		private IEnumerator SetElementTextWithIconImage(string orgStr, Image icon);
		private void ApplyReshowSetting();
	}
}
