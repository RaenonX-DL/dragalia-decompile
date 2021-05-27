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
	public class FacilitySortSettingToggle : CommonSettingToggleBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject layoutParentGameObject;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[Header]
		[SerializeField]
		private ElementalType elementalType;
		[SerializeField]
		private WeaponType weaponType;
		[SerializeField]
		private FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState facilityStateType;
		[Header]
		[SerializeField]
		private FacilitySortModel.Condition.SortCondition.SortType sortType;
		[SerializeField]
		private FacilitySortModel.Condition.SortCondition.SortOrder sortOrder;
		private FacilitySortPopup popup;
	
		// Constructors
		public FacilitySortSettingToggle();
	
		// Methods
		public FacilitySortModel.Condition.FilterCondition.FacilityStateFilter.FacilityState GetFacilityStateType();
		public void SetupByCondition(FacilitySortModel.Condition condition, FacilitySortPopup popup);
		public override void OnToggleValueChanged(bool value);
		private void SetSortToggleText();
		public void ResetInitValueBySortType(FacilitySortModel.Condition.SortCondition.SortType sortType);
	}
}
