/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExtensionImageEffectChangeHSV : ExtensionImageEffect
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Material _material;
		[SerializeField]
		[Tooltip]
		private HSVParameterBase _HSVParameter;
		private int _propertyToIDHSVMatrix;
	
		// Properties
		public HSVParameterBase HSVParameter { get; }
	
		// Constructors
		public ExtensionImageEffectChangeHSV();
	
		// Methods
		private void Awake();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
