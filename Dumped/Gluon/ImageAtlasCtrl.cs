using UnityEngine;

namespace Gluon
{
	public class ImageAtlasCtrl : MonoBehaviour
	{
		[SerializeField]
		private Sprite[] sprites;

		private int targetIndex;

		[SerializeField]
		private float frame;

		private float timeCount;

		private void Update()
		{
		}
	}
}
