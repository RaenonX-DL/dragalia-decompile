using UnityEngine.Events;

namespace Gluon
{
	public class MyPagePresentGroupListCellData
	{
		public bool isReceived;

		public string groupName;

		public int quantity;

		public string duplicateText;

		public bool isShowDuplicateText;

		public MyPagePresentListPopup.NextScenePattern[] nextScenes;

		public UnityAction<MyPagePresentListPopup.NextScenePattern> pressedSceneButtonCallback;

		public UnityAction allCellUpdateCallback;
	}
}
