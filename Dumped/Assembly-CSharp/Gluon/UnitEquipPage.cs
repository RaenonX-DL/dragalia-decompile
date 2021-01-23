/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitEquipPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image weaponIcon;
		public GameObject weaponLvGO;
		public UnityEngine.UI.Text weaponLvText;
		public UnityEngine.UI.Text weaponNameText;
		public Image weaponSkinIcon;
		[Header]
		[SerializeField]
		public Image dragonIcon;
		public GameObject dragonLvGO;
		public UnityEngine.UI.Text dragonLvText;
		public UnityEngine.UI.Text dragonNameText;
		public GameObject noDragonIconGO;
	
		// Constructors
		public UnitEquipPage();
	
		// Methods
		public void SetupEquipPage();
		private void SetEquipDragonInfo();
		private void SetEquipWeaponInfo();
	}
}
