using UnityEngine;

namespace Gluon
{
	public class InGameTouchGuard : MonoBehaviour
	{
		[SerializeField]
		private RectTransform top;

		[SerializeField]
		private RectTransform bottom;

		public static void Create(GameObject parent, int siblingIndex = -1)
		{
		}

		private void Initialize()
		{
		}
	}
}
