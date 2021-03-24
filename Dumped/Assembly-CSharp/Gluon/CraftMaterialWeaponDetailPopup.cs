/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftMaterialWeaponDetailPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private CraftEvolutionBaseFrame materialWeaponDetail;
	
		// Constructors
		public CraftMaterialWeaponDetailPopup();
	
		// Methods
		public static CraftMaterialWeaponDetailPopup Create(bool showBlackLayer = true);
		public void InitPop(int weaponId);
		public override void OnOkButtonPressed();
	}
}
