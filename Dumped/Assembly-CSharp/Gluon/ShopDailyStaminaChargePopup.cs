/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopDailyStaminaChargePopup : PopupBase
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text singleStaminaChargeStatusText;
		public UnityEngine.UI.Text multiStaminaChargeStatusText;
		public Button chargeButton;
		private Action onChargeDone;
	
		// Constructors
		public ShopDailyStaminaChargePopup();
	
		// Methods
		public static ShopDailyStaminaChargePopup Create(Action onChargeDone);
		protected override void Start();
		public void OnChargeButtonPressed();
	}
}
