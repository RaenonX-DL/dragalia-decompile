/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitFlavorPage : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text flavorTitle;
		public UnityEngine.UI.Text flavorText;
		public TabBase tabController;
		public GameObject tabGO;
		public UnityEngine.UI.Text[] activeTabTexts;
		public UnityEngine.UI.Text[] inactiveTabTexts;
		public GameObject[] tabLocks;
		public Button[] tabLockButtons;
		public UnitDetailScene scene;
		private int maxLimitLevel;
		private const int defaultAmuletFlaverIndex = 0;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public AbilityCrestElement masterAmuletData;
			public UnitFlavorPage __4__this;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _SetupFlavorPage_b__0(int index, bool isFromUI);
		}
	
		// Constructors
		public UnitFlavorPage();
	
		// Methods
		public void SetupFlavorPage(UnitDetailModel.UnitDetailType type);
		public void SetFlavorText(string rawFlavor);
		public void SetFlavorTextForAmulet(AbilityCrestElement masterAmuletData, int limitBreakLevel);
		public void OnAmuletUnlockTabHintButtonPressed();
		[CompilerGenerated]
		private void _OnAmuletUnlockTabHintButtonPressed_b__14_0();
		[CompilerGenerated]
		private void _OnAmuletUnlockTabHintButtonPressed_b__14_1();
	}
}
