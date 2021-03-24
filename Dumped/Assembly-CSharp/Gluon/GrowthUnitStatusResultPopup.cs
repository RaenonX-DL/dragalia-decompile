/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUnitStatusResultPopup : CommonPopup
	{
		// Fields
		public CommonUnitIcon unitIcon;
		public UnityEngine.UI.Text beforeHpText;
		public UnityEngine.UI.Text beforeHpPlusText;
		public UnityEngine.UI.Text afterHpText;
		public UnityEngine.UI.Text afterHpPlusText;
		public UnityEngine.UI.Text beforeAtkText;
		public UnityEngine.UI.Text beforeAtkPlusText;
		public UnityEngine.UI.Text afterAtkText;
		public UnityEngine.UI.Text afterAtkPlusText;
		public UnityEngine.UI.Text beforePowerText;
		public UnityEngine.UI.Text beforeTotalPlusText;
		public UnityEngine.UI.Text afterPowerText;
		public UnityEngine.UI.Text afterTotalPlusText;
		public Action popAnimationEndedCallBack;
		private GrowthUnitEnhanceModel model;
		private static readonly Color positiveColor;
		private static readonly Color normalColor;
	
		// Constructors
		public GrowthUnitStatusResultPopup();
		static GrowthUnitStatusResultPopup();
	
		// Methods
		public static GrowthUnitStatusResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, int beforeBuildup, int beforePower);
		private void SetupWeaponStatus(int beforeBuildup, int beforePower);
		private void SetupCrestStatus(int beforeBuildup, int beforePower);
		private void SetText(UnityEngine.UI.Text beforeText, UnityEngine.UI.Text beforePlusText, UnityEngine.UI.Text afterText, UnityEngine.UI.Text afterPlusText, int before, int after, int plus);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__22_0();
	}
}
