using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CollectEventSelectCharaPopupCell : MonoBehaviour
	{
		public Image bgImage;

		public Text titleText;

		public GameObject lockGO;

		public Text unlockItemCount;

		public Image unlockItemIcon;

		private EventStoryElement data;

		private bool read;

		public void SetContent(EventStoryElement data)
		{
		}

		public void OnClick()
		{
		}

		private void OnStoryCellClicked()
		{
		}

		private void DownloadCompleteCallback(int storyId)
		{
		}

		private bool IsEnabled()
		{
			return default(bool);
		}
	}
}
