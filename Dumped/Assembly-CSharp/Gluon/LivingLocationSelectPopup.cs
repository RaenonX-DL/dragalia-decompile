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
	public class LivingLocationSelectPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text subTitleText;
		public LivingLocationSelectToggle[] toggles;
		private LocalizeUtil.LocationCode location;
		private bool isLocationChanged;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public LivingLocationSelectPopup popup;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public LivingLocationSelectPopup();
	
		// Methods
		public static LivingLocationSelectPopup Create(string locationStr);
		public void OnLocationChecked(LocalizeUtil.LocationCode selectedLocation);
	}
}
