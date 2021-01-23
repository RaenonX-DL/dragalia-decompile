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
	public class MenuVariousNotationPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text termsText;
		[SerializeField]
		private UnityEngine.UI.Text copyrightText;
		[SerializeField]
		private UnityEngine.UI.Text specifiedCommercialTransactionActText;
		[SerializeField]
		private UnityEngine.UI.Text paymentServicesActText;
		[SerializeField]
		private UnityEngine.UI.Text privacyPolicyText;
		[SerializeField]
		private UnityEngine.UI.Text healthPrecautionsText;
		[SerializeField]
		private GameObject specifiedCommercialTransactionActObj;
		[SerializeField]
		private GameObject paymentServicesActObj;
		public MenuPopup menuPopup;
	
		// Constructors
		public MenuVariousNotationPopup();
	
		// Methods
		public static MenuVariousNotationPopup Create();
		public void InitSetting();
		public void OnTermsButtonPressed();
		public void OnCopyrightButtonPressed();
		public void OnSpecifiedCommercialTransactionActButtonPressed();
		public void OnPaymentServicesActButtonPressed();
		public void OnPrivacyPolicyButtonPressed();
		public void OnHealthPrecautionsButtonPressed();
	}
}
