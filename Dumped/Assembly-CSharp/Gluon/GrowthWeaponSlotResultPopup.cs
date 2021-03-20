/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponSlotResultPopup : CommonPopup
	{
		// Fields
		public Image breforeType1SlotImage;
		public UnityEngine.UI.Text breforeType1SlotText;
		public Image breforeType2SlotImage;
		public UnityEngine.UI.Text breforeType2SlotText;
		public Image afterType1SlotImage;
		public UnityEngine.UI.Text afterType1SlotText;
		public Image afterType2SlotImage;
		public UnityEngine.UI.Text afterType2SlotText;
		public Action popAnimationEndedCallBack;
	
		// Constructors
		public GrowthWeaponSlotResultPopup();
	
		// Methods
		public static GrowthWeaponSlotResultPopup Create();
		public void InitPopup(int beforeType1Slot, int beforeType2Slot, int afterType1Slot, int afterType2Slot);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__11_0();
	}
}
