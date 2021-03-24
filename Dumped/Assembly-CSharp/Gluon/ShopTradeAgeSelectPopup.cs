/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ShopTradeAgeSelectPopup : PopupBase
	{
		// Fields
		private Action<AgeGroup> onAgeSelected;
		private Action onClose;
	
		// Nested types
		public enum AgeGroup
		{
			None = 0,
			Underaged = 1,
			Adult = 2
		}
	
		// Constructors
		public ShopTradeAgeSelectPopup();
	
		// Methods
		public static ShopTradeAgeSelectPopup Create(Action<AgeGroup> onAgeSelected, Action onClose = null);
		public void OnCancel();
		public void OnUnderagedSelected();
		public void OnAdultSelected();
		public void OnAgeSelected(AgeGroup ageGroup);
	}
}
