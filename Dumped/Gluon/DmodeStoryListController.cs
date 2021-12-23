using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeStoryListController : TableViewController<DmodeStoryListCellData>
	{
		[SerializeField]
		public float cellWidht;

		[SerializeField]
		public float cellHeight;

		[SerializeField]
		private AnimationListOneCol listAnimation;

		[SerializeField]
		private float enterAnimationDuration;

		public void Load(UnityAction<DmodeStoryListCellData> unityAction)
		{
		}

		protected override TableViewCell<DmodeStoryListCellData> CreateCellForIndex(int index)
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
