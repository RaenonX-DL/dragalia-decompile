/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OptionTimeInputPopup : PopupBase
	{
		// Fields
		public UnityEngine.UI.Text titleText;
		public Button[] numberButtons;
		public Button okButton;
		public Button clearButton;
		public UnityEngine.UI.Text[] displayNumberTexts;
		public UnityEngine.UI.Text[] placeHolderTexts;
		private int disableHour;
		private int disableMin;
		private int currentEditIndex;
		private int[] enteredNumber;
		private Action<int, int> onDecided;
	
		// Constructors
		public OptionTimeInputPopup();
	
		// Methods
		public static OptionTimeInputPopup Create();
		protected override void Start();
		public void OnNumberButtonClicked(int number);
		public void Setup(bool isStartTime, int startHour, int startMin, Action<int, int> onDecided);
		public void OnOKButton();
		public void OnCancelButton();
		public void OnClearButton();
		private void ClearDigits();
		private void SetNumberButtonEnableState(int number, bool value);
		private void EnableForDigit();
		[CompilerGenerated]
		private void _Start_b__12_0();
		[CompilerGenerated]
		private void _Start_b__12_1();
		[CompilerGenerated]
		private void _Start_b__12_2();
		[CompilerGenerated]
		private void _Start_b__12_3();
		[CompilerGenerated]
		private void _Start_b__12_4();
		[CompilerGenerated]
		private void _Start_b__12_5();
		[CompilerGenerated]
		private void _Start_b__12_6();
		[CompilerGenerated]
		private void _Start_b__12_7();
		[CompilerGenerated]
		private void _Start_b__12_8();
		[CompilerGenerated]
		private void _Start_b__12_9();
	}
}
