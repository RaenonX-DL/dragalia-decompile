/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RecoverStaminaMultiItemData
	{
		// Fields
		public int itemId;
		public int pointPerItem;
		public int sliderValue;
		public int sliderMax;
		public int sliderInvalidMax;
		public bool sliderDirty;
	
		// Constructors
		public RecoverStaminaMultiItemData();
	
		// Methods
		public void AdjustInvalidOnOtherSliderValueChanged(int currentValue, int maxValue);
		public bool CanSelectMore(out bool isSliderMax);
		internal void InitWithItem(ItemList itemList, int afterStamina, int absoluteStaminaMax);
	}
}
