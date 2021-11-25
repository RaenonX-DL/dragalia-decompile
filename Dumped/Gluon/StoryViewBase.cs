using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class StoryViewBase : MonoBehaviour
	{
		[SerializeField]
		private Button storyTabButton;

		[SerializeField]
		private Button eventTabButton;

		[SerializeField]
		private GameObject StoryListView;

		public UnityAction<StoryListCategory> tabButtonAction;

		public UnityAction<StoryListCellData> listButtonCallBack;

		private void Start()
		{
		}

		public void StoryTabEnable()
		{
		}

		public void EventTabEnable()
		{
		}

		public void SetStoryViewActive(bool active)
		{
		}
	}
}
