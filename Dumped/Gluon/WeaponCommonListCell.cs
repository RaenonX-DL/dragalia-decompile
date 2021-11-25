using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class WeaponCommonListCell : CommonIconListCell
	{
		[SerializeField]
		private Image image;

		[SerializeField]
		private Text weaponName;

		[SerializeField]
		private Text weaponHp;

		[SerializeField]
		private Text weaponAtk;

		[SerializeField]
		private Text hasCount;

		[SerializeField]
		private Text releaseCount;

		[SerializeField]
		private GameObject selectedEquippedCountGO;

		[SerializeField]
		private Text selectedEquippedCountText;

		[SerializeField]
		private Transform iconParentTransform;

		protected override void Start()
		{
		}

		public override void UpdateContent(CommonIconListCellData data)
		{
		}

		public void SetEquipRemainingCount(bool selected, int equippedCount, int equippableCount, bool isSupportFriend)
		{
		}

		public override void LoadUnitIcon()
		{
		}
	}
}
