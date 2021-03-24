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
	public class PostEffectSunShafts : ExtensionImageEffect
	{
		// Fields
		[SerializeField]
		[Tooltip]
		protected Material _sunShaftsMaterial;
		[SerializeField]
		[Tooltip]
		protected Material _simpleClearMaterial;
		[SerializeField]
		private SunShaftsParam _param;
	
		// Properties
		public SunShaftsParam Param { get; }
		public bool IsEnable { get; }
		public bool IsUseDepthTexture { get; }
	
		// Nested types
		[Serializable]
		public class SunShaftsParam
		{
			// Fields
			[Tooltip]
			public bool IsEnable;
			[Tooltip]
			public Transform SunTransform;
			[Tooltip]
			public Vector3 SunPosition;
			[Range]
			[Tooltip]
			public float sunShaftResolutionRate;
			[Tooltip]
			public SunShaftsShadeMode sunShaftsShadeMode;
			[Tooltip]
			public SunShaftsScreenBlendMode ScreenBlendMode;
			[Tooltip]
			public float SunShaftBlurRadius;
			[Tooltip]
			public Color SunColor;
			[Tooltip]
			public float SunPower;
			[Tooltip]
			public float CenterBrightness;
			[Tooltip]
			public float CenterMultiplex;
			[Tooltip]
			public bool IsEnabledBorderClear;
			[Tooltip]
			public float SunShaftIntensity;
			[Tooltip]
			public float BlackLevel;
			[Tooltip]
			public int BlurIterations;
			[NonSerialized]
			public RenderTexture CameraDepthTexture;
	
			// Nested types
			public enum SunShaftsShadeMode
			{
				Default = 0,
				Komorebi = 1
			}
	
			public enum SunShaftsScreenBlendMode
			{
				Screen = 0,
				Add = 1
			}
	
			// Constructors
			public SunShaftsParam();
	
			// Methods
			public void Setup(SunShaftsParam src);
		}
	
		// Constructors
		public PostEffectSunShafts();
	
		// Methods
		public bool CreateMaterial();
		public void ResetDepthTexture();
		private void DrawBorder(RenderTexture dest, Material material);
		private void Start();
		public override DepthTextureMode GetNeedDepthTextureMode();
		public override bool RenderImage(RenderTextureData srcRTData, RenderTextureData dstRTData, ref RenderTextureData outputRTData, bool isEnableDepthTexture);
		public void DestroyMaterial();
	}
}
