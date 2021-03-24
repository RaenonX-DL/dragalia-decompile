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
	public class GrowthWeaponListCell : MonoBehaviour
	{
		// Fields
		public CommonUnitIcon unitIcon;
		public UnityEngine.UI.Text weaponName;
		public UnityEngine.UI.Text weaponHp;
		public UnityEngine.UI.Text weaponAtk;
		public UnityEngine.UI.Text hasCount;
		public UnityEngine.UI.Text releaseCount;
		public GameObject redLabelObject;
		public GameObject blackLabelObject;
		public GameObject lockCellObject;
		public GameObject completeImageObject;
		public Badge growBadge;
		public Action<int> cellPressCallBack;
		private int weaponId;
	
		// Constructors
		public GrowthWeaponListCell();
	
		// Methods
		public void InitCell(int weaponId);
		public void UpdateCell();
		public void OnCellPressed();
		public void OncellLongPressed();
	}
}
