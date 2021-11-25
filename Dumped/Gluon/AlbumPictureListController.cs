using System.Collections.Generic;

namespace Gluon
{
	public class AlbumPictureListController : CommonIconListController
	{
		private CommonIconListType commonIconType;

		private CommonSortModel.Preset preset;

		public void LoadData(CommonIconListType type)
		{
		}

		public void OnSortButtonClicked()
		{
		}

		public void OnSortApplied()
		{
		}

		private List<ulong> CreateDataIdList(CommonIconListType type)
		{
			return null;
		}

		protected AlbumCommonIconCellData CreateAlbumCharacterCellData(int keyIdOrInvalidId)
		{
			return null;
		}

		protected T SetupCharacterCellData<T>(int keyId) where T : AlbumCommonIconCellData, new()
		{
			return null;
		}

		protected AlbumCommonIconCellData CreateAlbumDragonCellData(int keyIdOrInvalidId)
		{
			return null;
		}

		protected T SetupDragonCellData<T>(int keyId) where T : AlbumCommonIconCellData, new()
		{
			return null;
		}
	}
}
