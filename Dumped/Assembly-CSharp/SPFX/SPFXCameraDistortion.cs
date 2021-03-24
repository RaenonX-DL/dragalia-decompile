/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace SPFX
{
	[DefaultExecutionOrder]
	public class SPFXCameraDistortion : MonoBehaviour
	{
		// Fields
		public Material ReverseMaterial;
		public eDrawLayer[] DrawLayers;
		private Camera RefCamera;
		private RenderTexture ScreenCopy;
		private IntPtr ScreenCopyPtr;
	
		// Constructors
		public SPFXCameraDistortion();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		private void OnRenderImage(RenderTexture source, RenderTexture destination);
	}
}
