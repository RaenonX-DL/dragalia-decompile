using UnityEngine;

namespace Gluon
{
	public class RectTransformChanged : MonoBehaviour
	{
		private RectTransform rectTrans;

		[SerializeField]
		private RectTransform targetRectTrans;

		private void OnRectTransformDimensionsChange()
		{
		}
	}
}
