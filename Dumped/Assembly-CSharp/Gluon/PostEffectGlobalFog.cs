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
	public class PostEffectGlobalFog : ExtensionImageEffect
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private Material _material;
		[SerializeField]
		[Tooltip]
		private bool _enableDistanceFog;
		[SerializeField]
		[Tooltip]
		private bool _enableHeightFog;
		[SerializeField]
		[Tooltip]
		private DistanceFogParam _distanceFogParam;
		[SerializeField]
		[Tooltip]
		private HeightFogParam _heightFogParam;
	
		// Properties
		public bool enableDistanceFog { get; set; }
		public bool enableHeightFog { get; set; }
		public DistanceFogParam distanceFogParam { get; }
		public HeightFogParam heightFogParam { get; }
	
		// Nested types
		[Serializable]
		public class DistanceFogParam
		{
			// Fields
			[SerializeField]
			[Tooltip]
			public FogMode fogMode;
			[SerializeField]
			[Tooltip]
			public Color fogColor;
			[SerializeField]
			[Tooltip]
			public float density;
			[SerializeField]
			[Tooltip]
			public float start;
			[SerializeField]
			[Tooltip]
			public float end;
	
			// Constructors
			public DistanceFogParam();
		}
	
		[Serializable]
		public class HeightFogParam
		{
			// Fields
			[SerializeField]
			[Tooltip]
			public Color fogColor;
			[SerializeField]
			[Tooltip]
			public FogMode fogMode;
			[Range]
			[SerializeField]
			[Tooltip]
			public float decay;
			[Range]
			[SerializeField]
			[Tooltip]
			public float height;
			[Range]
			[SerializeField]
			[Tooltip]
			public float concentration;
			[SerializeField]
			[Tooltip]
			public bool enableDensitySmooth;
			[Range]
			[SerializeField]
			[Tooltip]
			public float densitySmoothMin;
			[Range]
			[SerializeField]
			[Tooltip]
			public float densitySmoothMax;
	
			// Constructors
			public HeightFogParam();
	
			// Methods
			public void Setup(HeightFogParam src);
		}
	
		// Constructors
		public PostEffectGlobalFog();
	
		// Methods
		public override DepthTextureMode GetNeedDepthTextureMode();
		private void Start();
		private void OnPreRender();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
	}
}
