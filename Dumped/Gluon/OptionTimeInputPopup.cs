using System;
using UnityEngine.UI;

namespace Gluon
{
	public class OptionTimeInputPopup : PopupBase
	{
		public Text titleText;

		public Button[] numberButtons;

		public Button okButton;

		public Button clearButton;

		public Text[] displayNumberTexts;

		public Text[] placeHolderTexts;

		private int disableHour;

		private int disableMin;

		private int currentEditIndex;

		private int[] enteredNumber;

		private Action<int, int> onDecided;

		public static OptionTimeInputPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnNumberButtonClicked(int number)
		{
		}

		public void Setup(bool isStartTime, int startHour, int startMin, Action<int, int> onDecided)
		{
		}

		public void OnOKButton()
		{
		}

		public void OnCancelButton()
		{
		}

		public void OnClearButton()
		{
		}

		private void ClearDigits()
		{
		}

		private void SetNumberButtonEnableState(int number, bool value)
		{
		}

		private void EnableForDigit()
		{
		}
	}
}
