/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SPFX;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CustomSPFXCameraDistortion : FixedImageEffect
	{
		// Fields
		public Material reverseMaterial;
		public eDrawLayer[] drawLayers;
		private Camera refCamera;
		private RenderTexture screenCopy;
		private IntPtr screenCopyPtr;
	
		// Constructors
		public CustomSPFXCameraDistortion();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
