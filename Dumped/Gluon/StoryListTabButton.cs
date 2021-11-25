using UnityEngine;

namespace Gluon
{
	public class StoryListTabButton : MonoBehaviour
	{
		public StoryListCategory tabType;

		[SerializeField]
		public StoryListTabButtonEvent tabPressed;

		public void TabPressed()
		{
		}
	}
}
