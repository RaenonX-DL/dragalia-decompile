using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FriendSortSettingToggle : CommonSettingToggleBase
	{
		[SerializeField]
		[Header("Components")]
		public GameObject layoutParentGameObject;

		public Text title;

		[SerializeField]
		[Header("Filter Setting")]
		public ElementalType elemental;

		public WeaponType weaponType;

		[SerializeField]
		[Header("Sort Setting")]
		public FriendSortModel.Condition.SortCondition.SortType sortType;

		public FriendSortModel.Condition.SortCondition.SortOrder sortOrder;

		private FriendSortPopup popup;

		public void SetupByCondition(FriendSortModel.Condition condition, FriendSortPopup popup)
		{
		}

		public override void OnToggleValueChanged(bool value)
		{
		}

		public void ResetInitValueBySortType(FriendSortModel.Condition.SortCondition.SortType sortType)
		{
		}
	}
}
