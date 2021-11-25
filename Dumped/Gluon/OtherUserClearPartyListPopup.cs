using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class OtherUserClearPartyListPopup : CommonPopup
	{
		public Text questName;

		public TabBase questDifficultyTab;

		public OtherUserClearPartyListController userClearPartyListController;

		public TabBase listPageTab;

		[HideInInspector]
		public SceneBase scene;

		private int questGroupId;

		private int[] questIds;

		private int currentQuestId;

		private int currentPageIndex;

		private TouchGuardObject buttonPressTouchGuardObject;

		public static OtherUserClearPartyListPopup Create(SceneBase scene)
		{
			return null;
		}

		public void InitPopup(int questGroupId, int[] questIds, bool isLoadList = true)
		{
		}

		private void InitializeSinglePlay()
		{
		}

		private void InitializeMultiPlay()
		{
		}

		public void SpecifOpenPage(int questId, int pageIndex, float scrollPos)
		{
		}

		private void DifficultyTabSelected(int index)
		{
		}

		private void PageTabSelected(int index)
		{
		}

		private void OnListCellButtonPressed(OtherUserClearPartyListCellData data, int partySwitchIndex)
		{
		}
	}
}
