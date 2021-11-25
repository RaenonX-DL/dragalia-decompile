using System;
using UnityEngine;

namespace SPFX
{
	public class SPFXCameraDistortion : MonoBehaviour
	{
		public Material ReverseMaterial;

		public eDrawLayer[] DrawLayers;

		private Camera RefCamera;

		private RenderTexture ScreenCopy;

		private IntPtr ScreenCopyPtr;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
