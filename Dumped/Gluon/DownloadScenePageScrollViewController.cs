using UnityEngine;

namespace Gluon
{
	public class DownloadScenePageScrollViewController : MonoBehaviour
	{
		public PageViewBase pageViewBase;

		[SerializeField]
		public GameObject content;

		[SerializeField]
		public Sprite[] sprites;

		public Vector2[] offsets;

		private void Start()
		{
		}
	}
}
