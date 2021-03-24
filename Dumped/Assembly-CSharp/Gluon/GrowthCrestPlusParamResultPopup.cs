/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCrestPlusParamResultPopup : CommonPopup
	{
		// Fields
		public CommonUnitIcon unitIcon;
		public UnityEngine.UI.Text beforeHpPlusText;
		public UnityEngine.UI.Text beforeAtkPlusText;
		public UnityEngine.UI.Text afterHpPlusText;
		public UnityEngine.UI.Text afterAtkPlusText;
		public UnityEngine.UI.Text beforeTotalPlusText;
		public UnityEngine.UI.Text afterTotalPlusText;
		public UnityEngine.UI.Text beforeHpText;
		public UnityEngine.UI.Text afterHpText;
		public UnityEngine.UI.Text beforeAtkText;
		public UnityEngine.UI.Text afterAtkText;
		public UnityEngine.UI.Text beforePowerText;
		public UnityEngine.UI.Text afterPowerText;
	
		// Nested types
		public class BeforeData
		{
			// Fields
			public int hp;
			public int hpPlus;
			public int atk;
			public int atkPlus;
			public int power;
			public int totalPlus;
	
			// Constructors
			public BeforeData();
		}
	
		// Constructors
		public GrowthCrestPlusParamResultPopup();
	
		// Methods
		public static GrowthCrestPlusParamResultPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model, BeforeData beforeData);
	}
}
