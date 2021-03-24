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
	public class FriendSortSettingToggle : CommonSettingToggleBase
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
		public FriendSortModel.Condition.SortCondition.SortType sortType;
		public FriendSortModel.Condition.SortCondition.SortOrder sortOrder;
		private FriendSortPopup popup;
	
		// Constructors
		public FriendSortSettingToggle();
	
		// Methods
		public void SetupByCondition(FriendSortModel.Condition condition, FriendSortPopup popup);
		public override void OnToggleValueChanged(bool value);
		public void ResetInitValueBySortType(FriendSortModel.Condition.SortCondition.SortType sortType);
	}
}
