using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TapEffect : MonoBehaviour
	{
		public static float normalScale;

		public static float bigScale;

		public Image image;

		public bool isBig;

		private RectTransform rectTransform;

		private void Awake()
		{
		}

		public void StartEffect(float x, float y)
		{
		}

		private IEnumerator EffectCoroutine()
		{
			return null;
		}
	}
}
