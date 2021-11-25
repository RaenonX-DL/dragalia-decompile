using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewIllustrationPageCell : TableViewCell<AlbumStoryReviewIllustrationPageCellData>
	{
		[SerializeField]
		private Image image;

		public UnityAction<int> onIllustrationPressed;

		public override void UpdateContent(AlbumStoryReviewIllustrationPageCellData itemData)
		{
		}

		public void OnIllustrationCell()
		{
		}
	}
}
