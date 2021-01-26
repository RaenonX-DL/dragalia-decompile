/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponSkinConfirmPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text messageText;
		public UnityEngine.UI.Text weaponName;
		public CommonUnitIcon weaponIcon;
	
		// Constructors
		public GrowthWeaponSkinConfirmPopup();
	
		// Methods
		public static GrowthWeaponSkinConfirmPopup Create();
		public void InitPopup(GrowthWeaponSkinConfirmData data);
		public void InitPopup(int weaponSkinId);
	}
}
