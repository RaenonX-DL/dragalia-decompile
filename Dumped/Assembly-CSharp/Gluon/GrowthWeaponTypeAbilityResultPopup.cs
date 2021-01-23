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
	public class GrowthWeaponTypeAbilityResultPopup : CommonPopup
	{
		// Fields
		public Image[] abilityIcons;
		public Action popAnimationEndedCallBack;
	
		// Constructors
		public GrowthWeaponTypeAbilityResultPopup();
	
		// Methods
		public static GrowthWeaponTypeAbilityResultPopup Create();
		public void InitPopup(int[] abilityDataIds);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__4_0();
	}
}
