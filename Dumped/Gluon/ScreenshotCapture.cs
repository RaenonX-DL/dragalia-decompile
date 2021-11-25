using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class ScreenshotCapture : MonoBehaviour
	{
		private static ScreenshotCapture _instance;

		[SerializeField]
		private Texture2D _image;

		private int _idx;

		public static ScreenshotCapture instance => null;

		public static bool hasInstance => default(bool);

		public Texture2D image
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public void Capture(int devide = 1, TextureFormat format = TextureFormat.ARGB32)
		{
		}

		private IEnumerator Co_Capture(int devide, TextureFormat format)
		{
			return null;
		}

		public void PrepareRenderTexture(int divide, TextureFormat format)
		{
		}

		public void RenderCameraGroupToImage(CameraGroup cameraGroup, int devide = 1)
		{
		}

		public void RenderCameraToImage(Camera cam, int devide = 1)
		{
		}

		public void SkipCapture(int devide = 1, TextureFormat format = TextureFormat.ARGB32, [Optional] UnityAction callback)
		{
		}

		private IEnumerator SkipCo_Capture(int devide, TextureFormat format, UnityAction callback)
		{
			return null;
		}

		public void DestroyImage()
		{
		}
	}
}
