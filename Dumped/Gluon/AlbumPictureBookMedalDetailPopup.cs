using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPictureBookMedalDetailPopup : CommonIconPopup
	{
		[SerializeField]
		private Text IconName;

		private AlbumPictureBookMedalCellData itemData;

		public static AlbumPictureBookMedalDetailPopup Create()
		{
			return null;
		}

		public void InitContent(AlbumPictureBookMedalCellData itemData)
		{
		}

		public override void OnCloseButtonPressed()
		{
		}

		public override void OnCancelButtonPressed()
		{
		}

		public override void OnOkButtonPressed()
		{
		}
	}
}
