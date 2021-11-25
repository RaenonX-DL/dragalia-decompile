using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class MyPagePostEffectSettings : MonoBehaviour
	{
		[HideInInspector]
		public MyPageScene scene;

		private const int maxIrisCount = 8;

		private GameObject[] worldIrisObjects;

		private GameObject irisPointPrefab;

		private Vector2[] irisSize;

		private Color fogColor;

		private float fogStartDistance;

		private float fogEndDistance;

		private IEnumerator Start()
		{
			return null;
		}

		public void ApplyToPostEffect(PostEffect effect, MyPagePostEffectParams param, Transform mapBase)
		{
		}

		public void UpdateMoveMapPostEffect(PostEffect effect, MyPagePostEffectParams param)
		{
		}

		public void UpdateSkitMapPostEffect(PostEffect effect, MyPagePostEffectParams param)
		{
		}

		public void Reset()
		{
		}
	}
}
