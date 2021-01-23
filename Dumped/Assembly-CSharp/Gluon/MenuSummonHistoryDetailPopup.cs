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
	public class MenuSummonHistoryDetailPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text summonName;
		[SerializeField]
		private UnityEngine.UI.Text summonDate;
		[SerializeField]
		private UnityEngine.UI.Text summonType;
		[SerializeField]
		private UnityEngine.UI.Text paymentType;
		[SerializeField]
		private UnityEngine.UI.Text unitName;
		[SerializeField]
		private UnityEngine.UI.Text unitRarity;
		[SerializeField]
		private UnityEngine.UI.Text summonDewPoint;
		[SerializeField]
		private UnityEngine.UI.Text summonPrize;
		[SerializeField]
		private UnityEngine.UI.Text summonPoint;
	
		// Constructors
		public MenuSummonHistoryDetailPopup();
	
		// Methods
		public static MenuSummonHistoryDetailPopup Create(MenuSummonHistoryCellData data);
		public void SetContent(MenuSummonHistoryCellData data);
	}
}
