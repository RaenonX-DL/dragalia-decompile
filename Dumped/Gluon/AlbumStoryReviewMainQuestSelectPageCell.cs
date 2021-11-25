using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewMainQuestSelectPageCell : TableViewCell<AlbumStoryReviewMainQuestSelectPageCellData>
	{
		[SerializeField]
		private Image chapterIcon;

		[SerializeField]
		private QuestListCellShaderExchanger shaderExchanger;

		[SerializeField]
		private GameObject[] language;

		[SerializeField]
		private GameObject[] numberBase;

		[SerializeField]
		private Text[] numberColumText;

		[SerializeField]
		private GameObject[] numberBaseEn;

		[SerializeField]
		private Text[] numberColumTextEn;

		public override void UpdateContent(AlbumStoryReviewMainQuestSelectPageCellData itemData)
		{
		}

		public void OnCellPressed()
		{
		}

		public void SetNumber(int number)
		{
		}
	}
}
