using UnityEngine;

namespace Gluon
{
	public class StoryLogListController : TableViewController<StoryLogListCellData>
	{
		public const float fontHeight = 32f;

		[SerializeField]
		private RectTransform scrollContentRect;

		protected override void Start()
		{
		}

		private void LoadData()
		{
		}

		protected override float GetCellHeightAtIndex(int index)
		{
			return default(float);
		}
	}
}
