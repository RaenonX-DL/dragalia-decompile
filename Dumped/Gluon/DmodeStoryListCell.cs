using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeStoryListCell : TableViewCell<DmodeStoryListCellData>
	{
		[SerializeField]
		private Button dmodeStoryCellButton;

		[SerializeField]
		private Image dmodeStoryCellBgImage;

		[SerializeField]
		private Text dmodeStoryTitleNameText;

		[SerializeField]
		private GameObject dmodeStoryLockLayer;

		[SerializeField]
		private Image newIconImage;

		[SerializeField]
		private Shader exchangeShader;

		public override void UpdateContent(DmodeStoryListCellData itemData)
		{
		}

		public void OnDmodeStoryListCellPressed()
		{
		}
	}
}
