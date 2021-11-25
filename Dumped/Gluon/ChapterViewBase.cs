using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ChapterViewBase : MonoBehaviour
	{
		public GameObject capterCellOrigin;

		public Image capterTitle;

		private List<ChapterCellData> chapterDataList;

		public void SetupChapterView(StoryListCellData data, float listScrollPos, UnityAction<int> pressButtonAction)
		{
		}

		private void GetChapterData()
		{
		}
	}
}
