/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineFog
	{
		// Fields
		[CompilerGenerated]
		private bool _EnableFog_k__BackingField;
		[CompilerGenerated]
		private bool _ChangeColor_k__BackingField;
		[CompilerGenerated]
		private Color _FogColor_k__BackingField;
		[CompilerGenerated]
		private bool _ChangeDistance_k__BackingField;
		[CompilerGenerated]
		private FogMode _DistanceFogMode_k__BackingField;
		[CompilerGenerated]
		private float _FogStart_k__BackingField;
		[CompilerGenerated]
		private float _FogEnd_k__BackingField;
		[CompilerGenerated]
		private float _FogDensity_k__BackingField;
		[CompilerGenerated]
		private bool _HeightFogEnable_k__BackingField;
		[CompilerGenerated]
		private Color _HeightFogColor_k__BackingField;
		[CompilerGenerated]
		private FogMode _HeightFogMode_k__BackingField;
		[CompilerGenerated]
		private float _HeightFogDecay_k__BackingField;
		[CompilerGenerated]
		private float _HeightFogHeight_k__BackingField;
		[CompilerGenerated]
		private float _HeightFogConcentration_k__BackingField;
		[CompilerGenerated]
		private bool _HeightFogEnableDensitySmooth_k__BackingField;
		[CompilerGenerated]
		private float _HeightFogDensitySmoothMin_k__BackingField;
		[CompilerGenerated]
		private float _HeightFogDensitySmoothMax_k__BackingField;
		private CuttTimelineKeyFogDataList _keys;
		[CompilerGenerated]
		private static bool _originalEnableFog_k__BackingField;
		[CompilerGenerated]
		private static Color _originalColor_k__BackingField;
		[CompilerGenerated]
		private static FogMode _originalFogMode_k__BackingField;
		[CompilerGenerated]
		private static float _originalFogStart_k__BackingField;
		[CompilerGenerated]
		private static float _originalFogEnd_k__BackingField;
		[CompilerGenerated]
		private static float _originalgDensity_k__BackingField;
		[CompilerGenerated]
		private PostEffectGlobalFog _postEffectGlobalFog_k__BackingField;
	
		// Properties
		public bool EnableFog { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool ChangeColor { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Color FogColor { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool ChangeDistance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FogMode DistanceFogMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float FogStart { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float FogEnd { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float FogDensity { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool HeightFogEnable { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Color HeightFogColor { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public FogMode HeightFogMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float HeightFogDecay { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float HeightFogHeight { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float HeightFogConcentration { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool HeightFogEnableDensitySmooth { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float HeightFogDensitySmoothMin { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float HeightFogDensitySmoothMax { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool originalEnableFog { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static Color originalColor { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static FogMode originalFogMode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static float originalFogStart { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static float originalFogEnd { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static float originalgDensity { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public PostEffectGlobalFog postEffectGlobalFog { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CuttTimelineFog();
	
		// Methods
		private static void GetOriginalFogData();
		private static void SetOriginalFogData();
		public static void InitFog();
		public static void ExitFog();
		public void Initialize(CuttTimelineKeyFogDataList keys, CuttTimelineControl timelineControl);
		public void AlterUpdate(float currentTime, float targetFps, int currentFrame);
	}
}
