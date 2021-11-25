using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AbilityInfoCommonListCell : CommonIconListCell
	{
		[SerializeField]
		private Transform iconParentTransform;

		[SerializeField]
		private Text abilityName;

		[SerializeField]
		private Text abilityDetail;

		[SerializeField]
		private GameObject blackMaskObject;

		protected override void Start()
		{
		}

		public override void UpdateContent(CommonIconListCellData data)
		{
		}

		public override void LoadUnitIcon()
		{
		}
	}
}
