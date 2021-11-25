using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewIllustrationPageController : TableViewController<AlbumStoryReviewIllustrationPageCellData>
	{
		[SerializeField]
		public float cellWidht;

		[SerializeField]
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private Text illustrationNothingText;

		private UnityAction<int> onIllustAction;

		public void LoadData(AlbumStoryGroupElement albumStoryGroupElement, UnityAction<int> unityAction)
		{
		}

		protected override TableViewCell<AlbumStoryReviewIllustrationPageCellData> CreateCellForIndex(int index)
		{
			return null;
		}

		protected override void UpdateContents()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}

		protected override float GetCellWidthAtIndex(int index)
		{
			return default(float);
		}
	}
}
