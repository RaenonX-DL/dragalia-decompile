using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class DmodeStoryListCellData
	{
		public DmodeStoryElement dmodeStoryElement;

		public UnityAction<DmodeStoryListCellData> onCellPressed;

		public bool isNew;

		public bool isReleased;

		public int storyReleasedCharaCount;

		public int storyReleasedMaxFloorNum;
	}
}
