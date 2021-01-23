/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponLimitResultPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text messageText;
		public CommonUnitIcon unitIcon;
		public GameObject limitBreakParamBase;
		public GameObject limitOverParamBase;
		public UnityEngine.UI.Text beforeLimitBreakText;
		public UnityEngine.UI.Text afterLimitBreakText;
		public UnityEngine.UI.Text beforeLimitOverText;
		public UnityEngine.UI.Text afterLimitOverText;
		public Action popAnimationEndedCallBack;
		private GrowthUnitEnhanceModel model;
	
		// Constructors
		public GrowthWeaponLimitResultPopup();
	
		// Methods
		public static GrowthWeaponLimitResultPopup Create();
		public void InitPopup(BuildupPieceType type, GrowthUnitEnhanceModel model, int beforeParam);
		private void SetLimitBreakResult(int beforeParam);
		private void SetLimitOverResult(int beforeParam);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		[CompilerGenerated]
		private void _StartShowAnimation_b__14_0();
	}
}
