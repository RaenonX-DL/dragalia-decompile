/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopRealMonyTableViewBottomPart : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text bottomText;
		public UnityEngine.UI.Text specifiedCommercialTransactionActText;
		public const string prefabPath = "Prefabs/OutGame/ShopTrade/Parts/ShopRealMonyTableViewBottomPart";
		[SerializeField]
		private GameObject paymentServicesActObj;
		[SerializeField]
		private GameObject specifiedCommercialActObj;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _OnRecoverFailedPaymentButtonPressed_b__3();
		}
	
		// Constructors
		public ShopRealMonyTableViewBottomPart();
	
		// Methods
		public static ShopRealMonyTableViewBottomPart Create(Transform parent);
		public static bool ShouldPaymentServiceActButtonOn();
		public static bool ShouldSpecifiedCommercialActButtonOn();
		private void Start();
		public void OnRecoverFailedPaymentButtonPressed();
		public void OnPaymentServicesActPressed();
		public static void OpenPaymentServicesAct();
		public void OnSpecifiedCommercialTransactionActPressed();
		public static void OpenSpecifiedCommercialTransactionAct();
		[CompilerGenerated]
		private void _OnRecoverFailedPaymentButtonPressed_b__9_0();
		[CompilerGenerated]
		private void _OnRecoverFailedPaymentButtonPressed_b__9_1(int diaCount);
		[CompilerGenerated]
		private void _OnRecoverFailedPaymentButtonPressed_b__9_2(ShopGetListResponse getListRes);
	}
}
