using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewEventQuestSelectPageCell : TableViewCell<AlbumStoryReviewEventQuestSelectPageCellData>
	{
		[SerializeField]
		private Image logoImage;

		[SerializeField]
		private QuestListCellShaderExchanger shaderExchanger;

		public override void UpdateContent(AlbumStoryReviewEventQuestSelectPageCellData itemData)
		{
		}

		public void OnCellPressed()
		{
		}
	}
}
