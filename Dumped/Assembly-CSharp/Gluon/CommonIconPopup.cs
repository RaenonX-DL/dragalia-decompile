/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonIconPopup : CommonPopup
	{
		// Fields
		public CommonIcon commonIcon;
	
		// Constructors
		public CommonIconPopup();
	
		// Methods
		public static CommonIconPopup CreatePopup(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true);
		public void SetImageMaterial(Material mat);
		public void SetupByGiftTypeAndId(GiftType giftType, int id, IconLoader.Size size = IconLoader.Size.M, int level = 1, int limitBreak = 0, int rarity = 3, int additionalMaxLevel = 0);
		public CommonIconListSortDeco CreateDeco(IconLoader.Size iconSize);
		public void IsCommonIconButtonEvent(bool value);
	}
}
