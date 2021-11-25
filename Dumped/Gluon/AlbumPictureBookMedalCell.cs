using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumPictureBookMedalCell : TableViewCell<AlbumPictureBookMedalCellData>
	{
		[SerializeField]
		private RawImage medal;

		[SerializeField]
		private GameObject countPlate;

		[SerializeField]
		private Text text;

		[SerializeField]
		private Button button;

		public override void UpdateContent(AlbumPictureBookMedalCellData itemData)
		{
		}

		public void OnIconPressed()
		{
		}
	}
}
