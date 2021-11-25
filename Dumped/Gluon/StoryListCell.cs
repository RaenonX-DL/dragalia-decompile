using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryListCell : TableViewCell<StoryListCellData>
	{
		public Text storyTitle;

		[SerializeField]
		public StoryButtonEvent buttonPressed;

		public override void UpdateContent(StoryListCellData data)
		{
		}

		public void OnButtonPressed()
		{
		}

		private IEnumerator DelayAction(float delay, Action action)
		{
			return null;
		}
	}
}
