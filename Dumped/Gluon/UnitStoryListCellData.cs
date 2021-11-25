using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class UnitStoryListCellData
	{
		public UnitStoryElement storyElement;

		public UnitStoryGroupElement groupElement;

		public string triggerStoryTitle;

		public bool isNew;

		public bool isLock;

		public int unlockNum;

		public CharaDataElement charaElement;

		public int isPickup;

		public CastleStoryElement castleStoryElement;

		public bool isShortage;

		public UnityAction<int> callback;
	}
}
