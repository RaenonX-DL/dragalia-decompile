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
	public class ShopDailyCrystalClaimDonePopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text commentText;
		public UnityEngine.UI.Text remainText;
		public CommonIcon[] icons;
		[Header]
		[SerializeField]
		public GameObject closeButtonGO;
		public GameObject okCancelButtonGO;
		[Header]
		[SerializeField]
		public PointerEventHandler closeButtonPE;
		public PointerEventHandler cancelButtonPE;
		private int remainDays;
		private bool preOrderable;
		private EntityData[] receivedData;
	
		// Constructors
		public ShopDailyCrystalClaimDonePopup();
	
		// Methods
		public static ShopDailyCrystalClaimDonePopup Create(int remainDays, bool preOrderable, EntityData[] receivedData);
		protected override void Start();
		public void OnPurchaseButtonPressed();
	}
}
