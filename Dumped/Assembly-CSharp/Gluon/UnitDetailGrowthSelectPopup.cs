/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailGrowthSelectPopup : PopupBase
	{
		// Fields
		public GameObject charaPanel;
		public GameObject dragonPanel;
		public GameObject weaponPanel;
		public GameObject amuletPanel;
		public Button[] powerUpButtons;
		public Button awakenButton;
		public Button manaCircleButton;
		public Button[] limitBreakButtons;
		public Button gradeupButton;
		public UnitDetailScene scene;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public ulong keyId;
			public UnitDetailGrowthSelectPopup __4__this;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _OnPowerUpButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public ulong keyId;
			public UnitDetailGrowthSelectPopup __4__this;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnManaCircleButtonPressed_b__0();
			internal void _OnManaCircleButtonPressed_b__1();
			internal void _OnManaCircleButtonPressed_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_1
		{
			// Fields
			public bool isReloadManaCircle;
			public __c__DisplayClass14_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass14_1();
	
			// Methods
			internal void _OnManaCircleButtonPressed_b__3();
		}
	
		// Constructors
		public UnitDetailGrowthSelectPopup();
	
		// Methods
		public static UnitDetailGrowthSelectPopup Create();
		public void Setup();
		public void OnPowerUpButtonPressed();
		public void OnAwakenButtonPressed();
		public void OnManaCircleButtonPressed();
		[CompilerGenerated]
		private void _OnAwakenButtonPressed_b__13_0();
		[CompilerGenerated]
		private void _OnAwakenButtonPressed_b__13_1();
	}
}
