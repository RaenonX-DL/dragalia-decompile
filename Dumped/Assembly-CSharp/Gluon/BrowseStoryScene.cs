/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BrowseStoryScene : SceneBase
	{
		// Fields
		public GameObject bgPanel;
		public Canvas mainCanvas;
		private StoryViewBase storyViewBase;
		private GameObject chapterListObject;
		private static BrowseStorySaveData saveData;
	
		// Constructors
		public BrowseStoryScene();
		static BrowseStoryScene();
	
		// Methods
		private void Start();
		private void OnDestroy();
		public void ShowMainStory();
		public void ShowEvent();
		private void ListTabPressed(StoryListCategory tabType);
		private void ListButtonPressed(StoryListCellData data);
		private void ShowChapterList(StoryListCellData data);
		private void ShowStoryList();
		private void BackButtonPressed();
		private void CallStoryScene(int storyId);
	}
}
