using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class MissionGuideListController : TableViewController<MissionGuideListCellData>
	{
		public enum ContentType
		{
			None,
			MainStory,
			Event,
			EventOr,
			WallLevel,
			MultiCondition
		}

		public float cellWidth;

		public float cellHeight;

		public int currentContentDataId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void LoadGuideList()
		{
		}

		private void AutoScrollToCurrentContent()
		{
		}

		public static bool IsClearContent(MainStoryGuideElement mainStoryGuideElement)
		{
			return default(bool);
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
