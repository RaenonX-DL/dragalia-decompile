/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryMessageCreatePopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Inquiry/InquiryMessageCreatePopup";
		private const string datetimeAm = "am";
		private const string datetimePm = "pm";
		private readonly Color fixedFontColor;
		[SerializeField]
		private Button okButton;
		[SerializeField]
		private DragEventScrollRect scrollRect;
		[SerializeField]
		private InquiryFaqBoxUI inquiryFaqBoxUI;
		[SerializeField]
		private UnityEngine.UI.Text cautionText;
		private int inquiryIndex;
		[SerializeField]
		private UnityEngine.UI.Text inquiryTypeText;
		private int occurYear;
		private int occurMonth;
		private int occurDay;
		private int occurHour;
		private int occurMinute;
		private bool isJpDatetime;
		[SerializeField]
		private GameObject datetimeJpBase;
		[SerializeField]
		private UnityEngine.UI.Text occurYearText;
		[SerializeField]
		private UnityEngine.UI.Text occurMonthText;
		[SerializeField]
		private UnityEngine.UI.Text occurDayText;
		[SerializeField]
		private UnityEngine.UI.Text occurHourText;
		[SerializeField]
		private UnityEngine.UI.Text occurMinuteText;
		[SerializeField]
		private UnityEngine.UI.Text unitMonth;
		[SerializeField]
		private UnityEngine.UI.Text unitDay;
		[SerializeField]
		private UnityEngine.UI.Text unitHour;
		[SerializeField]
		private UnityEngine.UI.Text unitMinute;
		[SerializeField]
		private GameObject datetimeEngBase;
		[SerializeField]
		private UnityEngine.UI.Text occurYearEngText;
		[SerializeField]
		private UnityEngine.UI.Text occurMonthEngText;
		[SerializeField]
		private UnityEngine.UI.Text occurDayEngText;
		[SerializeField]
		private UnityEngine.UI.Text occurHourEngText;
		[SerializeField]
		private UnityEngine.UI.Text occurMinuteEngText;
		[SerializeField]
		private UnityEngine.UI.Text occurAmPmEngText;
		private List<int> yearList;
		[SerializeField]
		private LayoutElement inquiryDetailInputBaseLayout;
		[SerializeField]
		private InputField inquiryDetailInput;
		[SerializeField]
		private UnityEngine.UI.Text inputPlaceHolder;
		[SerializeField]
		private UnityEngine.UI.Text dummyText;
		[SerializeField]
		private UnityEngine.UI.Text inputCharText;
		[SerializeField]
		private UnityEngine.UI.Text maxCharText;
		private const int maxChar = 1000;
	
		// Properties
		public int InquryIndex { get; }
		public DateTime OccuerDateTime { get; }
		public string Detail { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public CommonPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _OnCloseButtonPressed_b__0();
			internal void _OnCloseButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public InquiryMessageCreatePopup __4__this;
			public DrumScrollPopup popup;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _OnChooseInquiryType_b__0(int index, GameObject obj);
			internal void _OnChooseInquiryType_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public DrumScrollPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal void _OnYearPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public InquiryMessageCreatePopup __4__this;
			public DrumScrollPopup popup;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal void _OnMonthPressed_b__0(int index, GameObject obj);
			internal void _OnMonthPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass65_0
		{
			// Fields
			public DrumScrollPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass65_0();
	
			// Methods
			internal void _OnDayPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction<int, GameObject> __9__65_0;
			public static UnityAction<int, GameObject> __9__66_0;
			public static UnityAction<int, GameObject> __9__67_0;
			public static UnityAction<int, GameObject> __9__68_0;
			public static Action __9__69_0;
			public static Action<ErrorType, int> __9__69_1;
			public static Action __9__70_0;
			public static Action<ErrorType, int> __9__70_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnDayPressed_b__65_0(int index, GameObject obj);
			internal void _OnHourPressed_b__66_0(int index, GameObject obj);
			internal void _OnMinutePressed_b__67_0(int index, GameObject obj);
			internal void _OnAmPmPressed_b__68_0(int index, GameObject obj);
			internal void _OnFaqPressed_b__69_0();
			internal void _OnFaqPressed_b__69_1(ErrorType errorType, int resultCode);
			internal void _OnBeforeInquiryCautionPressed_b__70_0();
			internal void _OnBeforeInquiryCautionPressed_b__70_1(ErrorType errorType, int resultCode);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public DrumScrollPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _OnHourPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass67_0
		{
			// Fields
			public DrumScrollPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass67_0();
	
			// Methods
			internal void _OnMinutePressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public DrumScrollPopup popup;
			public InquiryMessageCreatePopup __4__this;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _OnAmPmPressed_b__1();
		}
	
		// Constructors
		public InquiryMessageCreatePopup();
	
		// Methods
		public static InquiryMessageCreatePopup Create();
		public void InitSetting(int initInquiryIndex, DateTime initOccurTime, string initDetail);
		private void SetInputChar(int count);
		private void UpdateOkButtonState();
		private string GetInquiryType(int index);
		private void SetInquiryIndex(int index);
		private void SetYear(int year);
		private void SetMonthIndex(int month);
		private void SetDay(int day);
		private void SetHour(int index);
		private void SetMinute(int index);
		public void OnOKButtonPressed();
		public void OnCloseButtonPressed();
		public void OnChooseInquiryType();
		public void OnValueChangedDetail(string text);
		public void OnEndEditDetail(string text);
		public void OnYearPressed();
		public void OnMonthPressed();
		public void OnDayPressed();
		public void OnHourPressed();
		public void OnMinutePressed();
		public void OnAmPmPressed();
		public void OnFaqPressed();
		public void OnBeforeInquiryCautionPressed();
		[CompilerGenerated]
		private bool _OnYearPressed_b__63_0(int year);
		[CompilerGenerated]
		private void _OnYearPressed_b__63_1(int index, GameObject obj);
	}
}
