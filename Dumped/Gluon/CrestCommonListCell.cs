using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CrestCommonListCell : CommonIconListCell
	{
		public const float cellHieght = 168f;

		public const float cellWidth = 284f;

		[SerializeField]
		private Transform cellBaseTransform;

		[SerializeField]
		private Transform outButtonTransform;

		[SerializeField]
		private Image unionIcon;

		[SerializeField]
		private GameObject noneUnionGameObject;

		[SerializeField]
		private Text releaseCount;

		[SerializeField]
		private Text ability;

		[SerializeField]
		private Transform iconParentTransform;

		[SerializeField]
		private GameObject eventBonusIcon;

		[SerializeField]
		private GameObject equipCountGO;

		[SerializeField]
		private Text equipCountText;

		[SerializeField]
		private GameObject notEquipGO;

		private Button button;

		protected override void Awake()
		{
		}

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
