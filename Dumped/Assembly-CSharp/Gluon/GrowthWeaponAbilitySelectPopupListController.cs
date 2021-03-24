/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponAbilitySelectPopupListController : CommonIconListController
	{
		// Fields
		[HideInInspector]
		public int targetWeaponId;
		[HideInInspector]
		public int totalUseRupi;
		public Dictionary<int, int> needMaterialData;
	
		// Constructors
		public GrowthWeaponAbilitySelectPopupListController();
	
		// Methods
		protected override CommonIconListCellData CreateWeaponPassiveAbilityCellData(ulong keyIdOrInvalidId, int decoNum);
		public void UpdateCellDataSelectNumber(List<int> selectList);
		private bool IsReleasablePassiveAbility(int dataId);
		public void UpdateReleasableFlag(List<int> selectList);
	}
}
