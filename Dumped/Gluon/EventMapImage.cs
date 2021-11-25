using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventMapImage : MonoBehaviour
	{
		[SerializeField]
		public RawImage render3dImage;

		[SerializeField]
		public Camera render3dCamera;

		private bool is3DBgLoaded;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private IEnumerator Load3DBgSceneCoroutine(string filename)
		{
			return null;
		}

		public IEnumerator SetupRenderBg(string filename)
		{
			return null;
		}
	}
}
