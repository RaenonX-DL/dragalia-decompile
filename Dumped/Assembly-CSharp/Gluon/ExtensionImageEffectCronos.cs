/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExtensionImageEffectCronos : ExtensionImageEffect
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Material _material;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _fadeValue;
		private int _propertyToIDFadeValue;
		[SerializeField]
		[Tooltip]
		private HSVParameterBase _HSVParameter;
	
		// Properties
		public float fadeValue { set; }
	
		// Constructors
		public ExtensionImageEffectCronos();
	
		// Methods
		private void Awake();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
