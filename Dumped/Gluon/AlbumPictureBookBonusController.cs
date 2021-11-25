using UnityEngine;

namespace Gluon
{
	public class AlbumPictureBookBonusController : TabContentBase
	{
		[SerializeField]
		[Header("Group")]
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

		private AlbumPictureBookBonusCell CreateFortDetailCell()
		{
			return null;
		}
	}
}
