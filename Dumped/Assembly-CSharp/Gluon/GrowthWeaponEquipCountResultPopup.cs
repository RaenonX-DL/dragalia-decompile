/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponEquipCountResultPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text beforeCountText;
		public UnityEngine.UI.Text afterCountText;
		public Action popAnimationEndedCallBack;
	
		// Constructors
		public GrowthWeaponEquipCountResultPopup();
	
		// Methods
		public static GrowthWeaponEquipCountResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, int beforeCount);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__5_0();
	}
}
