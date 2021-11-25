using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CollectEventSelectCharaPopup : PopupBase
	{
		public TabBase tabController;

		public Transform unreadContent;

		public Transform allContent;

		public CollectEventSelectCharaPopupCell cellTemplate;

		[SerializeField]
		private Text releaseItemCountText;

		[SerializeField]
		private Image releaseItemImgage;

		[SerializeField]
		private Text completeText;

		private int eventId;

		public const string prefabPath = "Prefabs/OutGame/EventQuest/CollectEventSelectCharaPopup";

		public static CollectEventSelectCharaPopup Create(int eventId)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnSelectedTypeTab(int index)
		{
		}
	}
}
