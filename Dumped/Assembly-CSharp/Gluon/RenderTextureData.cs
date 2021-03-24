/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public struct RenderTextureData
	{
		// Fields
		public RenderTexture colorTexture;
		public RenderTexture depthTexture;
	
		// Properties
		public int width { get; }
		public int height { get; }
	
		// Constructors
		public RenderTextureData(RenderTexture rt);
		public RenderTextureData(RenderTexture colorRT, RenderTexture depthRT);
	
		// Methods
		public void SetRenderTarget(bool isSetColor = true);
	}
}
