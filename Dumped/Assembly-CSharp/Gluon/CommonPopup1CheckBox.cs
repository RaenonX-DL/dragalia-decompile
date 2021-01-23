/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonPopup1CheckBox : CommonPopup
	{
		// Fields
		public GameObject TermsOfService;
		public GameObject AgeVerification;
		public UnityEngine.UI.Text birthDateText;
		private static CommonPopup1CheckBox popup;
		public UnityEngine.UI.Text limitTextOver20;
		public UnityEngine.UI.Text limitTextOver16Under20;
		public UnityEngine.UI.Text limitTextUnder16;
	
		// Nested types
		public enum TextSet
		{
			None = 0,
			TermsOfService = 1,
			AgeVerification = 2
		}
	
		// Constructors
		public CommonPopup1CheckBox();
	
		// Methods
		public static CommonPopup1CheckBox OriginalCreate(TextSet setText, Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showText = false, bool showBlackLayer = false);
		public void SetFixTextType(TextSet setText);
		public void SetBirthDate(int year, int mon);
	}
}
