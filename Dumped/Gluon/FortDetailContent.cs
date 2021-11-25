using UnityEngine;

namespace Gluon
{
	public class FortDetailContent : TabContentBase
	{
		[SerializeField]
		[Header("æ\u0096½è\u00a8­Group")]
		public FortMenuGroupType facilityGroup;

		[SerializeField]
		protected RectTransform prefab;

		[SerializeField]
		protected Transform contentParent;

		private void Start()
		{
		}

		private bool IsFortPlantTypeExist(FortPlantType type)
		{
			return default(bool);
		}

		private FortDetailCell CreateFortDetailCell()
		{
			return null;
		}
	}
}
