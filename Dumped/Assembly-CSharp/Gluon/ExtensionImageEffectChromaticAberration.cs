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
	public class ExtensionImageEffectChromaticAberration : ExtensionImageEffect
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Material _material;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _aberrationSize;
		private int _propertyToIDAberrationSize;
	
		// Properties
		public float aberrationSize { set; }
	
		// Constructors
		public ExtensionImageEffectChromaticAberration();
	
		// Methods
		private void Awake();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
