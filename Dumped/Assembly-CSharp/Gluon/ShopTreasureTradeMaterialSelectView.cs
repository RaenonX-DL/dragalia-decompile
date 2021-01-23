/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTreasureTradeMaterialSelectView : ShopTradePanelBase
	{
		// Fields
		private UnityAction onDecideButtonPressedCallback;
		private string captionTitle;
		private CaptionCanvas.IconType captionIconType;
	
		// Constructors
		public ShopTreasureTradeMaterialSelectView();
	
		// Methods
		public static ShopTreasureTradeMaterialSelectView Create(Transform parent, ShopTradeScene scene);
		private void Start();
		public void SetCaptionInfo(string title, CaptionCanvas.IconType iconType);
		public void OnCellButtonPressed(int groupId);
		public void SetOnDecideButtonPressedCallback(UnityAction callback);
		public void OnDecideButtonPressed();
	}
}
