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
	public class GrowthWeaponTypeBonusSeriesCell : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text seriesTitle;
		public Transform cellParentTransform;
		public GameObject originCell;
		[HideInInspector]
		public int seriesIndex;
	
		// Constructors
		public GrowthWeaponTypeBonusSeriesCell();
	
		// Methods
		public void InitCell(int seriesIndex);
		public void AddCell(int weaponId);
	}
}
