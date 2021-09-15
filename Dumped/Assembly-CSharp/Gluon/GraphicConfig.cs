/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.GraphicParameter;
using Gluon.PostEffectParams;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class GraphicConfig
	{
		// Fields
		public int ResolutionRate;
		public int FrameRate;
		private FilterUseType _filterUseType;
		private bool isFilterUseTypeDirty;
		private FilterUseType _filterUseType2D;
		private bool isFilterUseTypeDirty2D;
		private bool enableRimSilhouette;
		private bool isEnableRimSilhouetteDirty;
		private bool offBackground;
		private bool isOffBackgroundDirty;
		private bool offEffect;
		private bool isOffEffectDirty;
		private bool enableLightMap;
		private bool isEnableLightMapDirty;
		private LodLevel shaderLodLevel;
		private bool isShaderLodLevelDirty;
		private LodLevel objectLodLevel;
		private bool isObjectLodLevelDirty;
		private bool enableReflection;
		private bool isEnableReflectionDirty;
		private CharaShaderParameter.QualityLevel _charaShaderQuality;
		private bool _charaShaderQualityDirty;
		private bool shadowAllCharacter;
		private bool isShadowAllCharacterDirty;
		private bool enableAntiAliasing;
		private bool isEnableAntiAliasingDirty;
		private static GraphicConfig _instance;
	
		// Properties
		public FilterUseType FilterUseType { get; set; }
		public FilterUseType FilterUseType2D { get; set; }
		public bool EnableRimSilhouette { get; set; }
		public bool OffBackground { get; set; }
		public bool OffEffect { get; set; }
		public bool EnableLightMap { get; set; }
		public LodLevel ShaderLodLevel { get; set; }
		public LodLevel ObjectLodLevel { get; set; }
		public bool EnableReflection { get; set; }
		public CharaShaderParameter.QualityLevel charaShaderQuality { get; set; }
		public bool ShadowAllCharacter { get; set; }
		public bool EnableAntiAliasing { get; set; }
		public static GraphicConfig Instance { get; }
		public static bool HasInstance { get; }
	
		// Constructors
		public GraphicConfig();
	
		// Methods
		public void SetQualitySettingHigh();
		public void SetQualitySettingMiddle();
		public void SetQualitySettingLow();
		public void SetQualitySettingLowest();
		public void ApplySetting(bool force = false);
		public void SetPostEffect(FilterUseType filterUseType);
		public void OnChangePostEffect(bool force = false);
		public void OnChangeRimSilhouette(bool force = false);
		public void OnChangeOffBackground(bool force = false);
		public void OnChangeOffEffect(bool force = false);
		public void OnChangeLightMap(bool force = false);
		public void OnChangeShaderLodLevel(bool force = false);
		public void OnChangeObjectLodLevel(bool force = false);
		public void OnChangeReflection(bool force);
		public void OnChangeCharaShaderType(bool force);
		public void OnChangeAntiAliasing(bool force);
		public void GetCharaShaderKeywordFlag(CharaShaderParameter charaShaderParameter);
	}
}
