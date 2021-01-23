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
	public class ShopDrawMaterialSummonPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text comment;
		public UnityEngine.UI.Text priceText;
		public UnityEngine.UI.Text beforeCountText;
		public UnityEngine.UI.Text afterCountText;
		public UnityEngine.UI.Text insufficientText;
		[Header]
		[SerializeField]
		public Button okButton;
		private int price;
		private Action onDraw;
	
		// Constructors
		public ShopDrawMaterialSummonPopup();
	
		// Methods
		public static ShopDrawMaterialSummonPopup Create(int price, Action onDraw);
		protected override void Start();
		public void OnSummonButtonPressed();
	}
}
