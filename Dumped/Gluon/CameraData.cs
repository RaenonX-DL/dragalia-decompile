using System;
using SPFX;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class CameraData
	{
		public string name;

		public Camera camera;

		public PostEffect postEffect;

		public CustomSPFXBlurController blurController;

		public SPFXCameraDistortion cameraDistortion;

		public CameraData(Camera c)
		{
		}
	}
}
