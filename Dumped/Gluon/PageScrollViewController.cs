using UnityEngine;

namespace Gluon
{
	public class PageScrollViewController : MonoBehaviour
	{
		public PageViewBase pageViewBase;

		[SerializeField]
		public GameObject content;

		[SerializeField]
		public Sprite[] sprites;

		[SerializeField]
		public Material[] notSpriteMaterial;

		private void Start()
		{
		}
	}
}
