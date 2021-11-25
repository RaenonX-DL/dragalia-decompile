using UnityEngine;

namespace Gluon
{
	public class BrowseStoryScene : SceneBase
	{
		public GameObject bgPanel;

		public Canvas mainCanvas;

		private StoryViewBase storyViewBase;

		private GameObject chapterListObject;

		private static BrowseStorySaveData saveData;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowMainStory()
		{
		}

		public void ShowEvent()
		{
		}

		private void ListTabPressed(StoryListCategory tabType)
		{
		}

		private void ListButtonPressed(StoryListCellData data)
		{
		}

		private void ShowChapterList(StoryListCellData data)
		{
		}

		private void ShowStoryList()
		{
		}

		private void BackButtonPressed()
		{
		}

		private void CallStoryScene(int storyId)
		{
		}
	}
}
