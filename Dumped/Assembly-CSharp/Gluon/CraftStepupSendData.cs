/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftStepupSendData
	{
		// Fields
		public int targetWeaponId;
		public int quantity;
		public bool isLimitBreak;
		public AtgenWeaponSetList[] weaponSetDatas;
	
		// Constructors
		public CraftStepupSendData();
	
		// Methods
		public static AtgenWeaponSetList[] ConvertMaterialWeaponCellDataToCraftSendData(int tragetWeaponId, int quantity, CraftMaterialCellData[] craftMaterialCellDatas);
		public static AtgenWeaponSetList[] ConvertMaterialWeaponCellDataToGradeupSendData(int targetWeaponId, CraftMaterialCellData[] craftMaterialCellDatas);
	}
}
