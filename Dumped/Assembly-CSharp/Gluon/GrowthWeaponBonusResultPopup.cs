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
	public class GrowthWeaponBonusResultPopup : CommonPopup
	{
		// Fields
		public Image weaponTypeIcon;
		public UnityEngine.UI.Text hpParamText;
		public UnityEngine.UI.Text atkParamText;
		public Action popAnimationEndedCallBack;
	
		// Constructors
		public GrowthWeaponBonusResultPopup();
	
		// Methods
		public static GrowthWeaponBonusResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__6_0();
	}
}
