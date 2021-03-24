/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RawImageWithAlphaBlend : RawImage
	{
		// Fields
		private RenderTexture rtB;
		private RenderTexture rtW;
		private Camera cam;
		private bool isSPFX;
		private bool useBlackBg;
		private const string externalWhiteAlphaTextureMat = "Materials/Common/UIDefaultWithExternalWhiteBGTexture";
		private const string externalBlackAlphaTextureMat = "Materials/Common/UIDefaultWithExternalBlackBGTexture";
	
		// Constructors
		public RawImageWithAlphaBlend();
	
		// Methods
		public void InitRenderTexture(string name, int w, int h, Camera cam, bool isSpark = false, bool useBlackBg = false);
		public bool IsExternalAlphaBlendEnabled();
		public void EnableExternalAlphaBlend(string nameAlphaRT);
		protected override void OnDestroy();
		public void ReleaseRenderTexture();
		private void Update();
	}
}
