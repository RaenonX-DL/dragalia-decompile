using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AlbumPictureBookMedalGroupCell : TableViewCell<AlbumPictureBookMedalCellGroupData>
	{
		[SerializeField]
		private List<AlbumPictureBookMedalCell> albumPictureBookMedalListCell;

		public override void UpdateContent(AlbumPictureBookMedalCellGroupData itemData)
		{
		}
	}
}
