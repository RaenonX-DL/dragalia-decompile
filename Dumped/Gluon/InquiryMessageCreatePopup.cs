using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class InquiryMessageCreatePopup : PopupBase
	{
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
		private Text cautionText;

		private int inquiryIndex;

		[SerializeField]
		private Text inquiryTypeText;

		private int occurYear;

		private int occurMonth;

		private int occurDay;

		private int occurHour;

		private int occurMinute;

		private bool isJpDatetime;

		[SerializeField]
		private GameObject datetimeJpBase;

		[SerializeField]
		private Text occurYearText;

		[SerializeField]
		private Text occurMonthText;

		[SerializeField]
		private Text occurDayText;

		[SerializeField]
		private Text occurHourText;

		[SerializeField]
		private Text occurMinuteText;

		[SerializeField]
		private Text unitMonth;

		[SerializeField]
		private Text unitDay;

		[SerializeField]
		private Text unitHour;

		[SerializeField]
		private Text unitMinute;

		[SerializeField]
		private GameObject datetimeEngBase;

		[SerializeField]
		private Text occurYearEngText;

		[SerializeField]
		private Text occurMonthEngText;

		[SerializeField]
		private Text occurDayEngText;

		[SerializeField]
		private Text occurHourEngText;

		[SerializeField]
		private Text occurMinuteEngText;

		[SerializeField]
		private Text occurAmPmEngText;

		private List<int> yearList;

		[SerializeField]
		private LayoutElement inquiryDetailInputBaseLayout;

		[SerializeField]
		private InputField inquiryDetailInput;

		[SerializeField]
		private Text inputPlaceHolder;

		[SerializeField]
		private Text dummyText;

		[SerializeField]
		private Text inputCharText;

		[SerializeField]
		private Text maxCharText;

		private const int maxChar = 1000;

		public int InquryIndex => default(int);

		public DateTime OccuerDateTime => default(DateTime);

		public string Detail => null;

		public static InquiryMessageCreatePopup Create()
		{
			return null;
		}

		public void InitSetting(int initInquiryIndex, DateTime initOccurTime, string initDetail)
		{
		}

		private void SetInputChar(int count)
		{
		}

		private void UpdateOkButtonState()
		{
		}

		private string GetInquiryType(int index)
		{
			return null;
		}

		private void SetInquiryIndex(int index)
		{
		}

		private void SetYear(int year)
		{
		}

		private void SetMonthIndex(int month)
		{
		}

		private void SetDay(int day)
		{
		}

		private void SetHour(int index)
		{
		}

		private void SetMinute(int index)
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnCloseButtonPressed()
		{
		}

		public void OnChooseInquiryType()
		{
		}

		public void OnValueChangedDetail(string text)
		{
		}

		public void OnEndEditDetail(string text)
		{
		}

		public void OnYearPressed()
		{
		}

		public void OnMonthPressed()
		{
		}

		public void OnDayPressed()
		{
		}

		public void OnHourPressed()
		{
		}

		public void OnMinutePressed()
		{
		}

		public void OnAmPmPressed()
		{
		}

		public void OnFaqPressed()
		{
		}

		public void OnBeforeInquiryCautionPressed()
		{
		}
	}
}
