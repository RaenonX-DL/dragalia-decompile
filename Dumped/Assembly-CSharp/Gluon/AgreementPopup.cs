/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AgreementPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text locationText;
		public UnityEngine.UI.Text locationButtonText;
		public UnityEngine.UI.Text agreementText;
		public UnityEngine.UI.Text agreementButtonText;
		public UnityEngine.UI.Text privacyPolicyButtonText;
		public Button locationButton;
		public Button agreementButton;
		public Button privacyPolicyButton;
		private string warningTextContent;
		private string agreementTextContent;
		private AgreementUtility utility;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public AgreementPopup popup;
			public UnityAction onCompleted;
			public Action<EulaGetVersionResponse> __9__4;
			public Action __9__2;
			public UnityAction __9__3;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _Create_b__0();
			internal void _Create_b__2();
			internal void _Create_b__4(EulaGetVersionResponse res);
			internal void _Create_b__3();
			internal void _Create_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1
		{
			// Fields
			public CommonPopup warningPopup;
			public __c__DisplayClass12_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass12_1();
	
			// Methods
			internal void _Create_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public UnityAction callback;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _EulaAgree_b__0(EulaAgreeAgreeResponse res);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public LivingLocationSelectPopup popup;
			public AgreementPopup __4__this;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _OnLocationButtonPressed_b__0();
			internal void _OnLocationButtonPressed_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__19_0;
			public static Action<ErrorType, int> __9__19_1;
			public static Action __9__20_0;
			public static Action<ErrorType, int> __9__20_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnAgreementButtonPressed_b__19_0();
			internal void _OnAgreementButtonPressed_b__19_1(ErrorType errorType, int resultCode);
			internal void _OnPrivacyPolicyButtonPressed_b__20_0();
			internal void _OnPrivacyPolicyButtonPressed_b__20_1(ErrorType errorType, int resultCode);
		}
	
		// Constructors
		public AgreementPopup();
	
		// Methods
		public static void CreateConfirmAgreement(UnityAction onCompleted, string location);
		private static AgreementPopup Create(UnityAction onCompleted);
		private void OnRefreshLocation();
		private void SetNOANOEText(string locationCode);
		private void EulaAgree(string locationCode, UnityAction callback);
		private void SetButtonActive(bool isActive = true);
		public void RefreshLocationButton(string locationStr = null);
		public void OnLocationButtonPressed();
		public void OnAgreementButtonPressed();
		public void OnPrivacyPolicyButtonPressed();
	}
}
