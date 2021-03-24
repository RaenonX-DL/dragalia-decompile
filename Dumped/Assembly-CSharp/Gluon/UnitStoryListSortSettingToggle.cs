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
	public class UnitStoryListSortSettingToggle : CommonSettingToggleBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject layoutParentGameObject;
		public UnityEngine.UI.Text title;
		[Header]
		[SerializeField]
		public ElementalType elemental;
		public WeaponType weaponType;
		[Header]
		[SerializeField]
		public UnitStoryListSortModel.Condition.SortCondition.SortType sortType;
		public UnitStoryListSortModel.Condition.SortCondition.SortOrder sortOrder;
		private UnitStoryListSortPopup popup;
	
		// Constructors
		public UnitStoryListSortSettingToggle();
	
		// Methods
		public void SetupByCondition(UnitStoryListSortModel.Condition condition, UnitStoryListSortPopup popup);
		public override void OnToggleValueChanged(bool value);
		public void ResetInitValueBySortType(UnitStoryListSortModel.Condition.SortCondition.SortType sortType);
	}
}
