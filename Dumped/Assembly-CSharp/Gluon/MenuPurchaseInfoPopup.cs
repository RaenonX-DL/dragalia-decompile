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
	public class MenuPurchaseInfoPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Menu/MenuPurchaseInfoPopup";
		[SerializeField]
		private UnityEngine.UI.Text purchasedStoneText;
		[SerializeField]
		private UnityEngine.UI.Text freeStoneText;
	
		// Constructors
		public MenuPurchaseInfoPopup();
	
		// Methods
		public static MenuPurchaseInfoPopup Create();
		public void InitSetting();
	}
}
