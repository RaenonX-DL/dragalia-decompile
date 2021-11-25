using System;
using Gluon.GraphicParameter;
using Gluon.PostEffectParams;

namespace Gluon
{
	[Serializable]
	public class GraphicConfig
	{
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

		public FilterUseType FilterUseType
		{
			get
			{
				return default(FilterUseType);
			}
			set
			{
			}
		}

		public FilterUseType FilterUseType2D
		{
			get
			{
				return default(FilterUseType);
			}
			set
			{
			}
		}

		public bool EnableRimSilhouette
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool OffBackground
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool OffEffect
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableLightMap
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public LodLevel ShaderLodLevel
		{
			get
			{
				return default(LodLevel);
			}
			set
			{
			}
		}

		public LodLevel ObjectLodLevel
		{
			get
			{
				return default(LodLevel);
			}
			set
			{
			}
		}

		public bool EnableReflection
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CharaShaderParameter.QualityLevel charaShaderQuality
		{
			get
			{
				return default(CharaShaderParameter.QualityLevel);
			}
			set
			{
			}
		}

		public bool ShadowAllCharacter
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EnableAntiAliasing
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static GraphicConfig Instance => null;

		public static bool HasInstance => default(bool);

		public void SetQualitySettingHigh()
		{
		}

		public void SetQualitySettingMiddle()
		{
		}

		public void SetQualitySettingLow()
		{
		}

		public void SetQualitySettingLowest()
		{
		}

		public void ApplySetting(bool force = false)
		{
		}

		public void SetPostEffect(FilterUseType filterUseType)
		{
		}

		public void OnChangePostEffect(bool force = false)
		{
		}

		public void OnChangeRimSilhouette(bool force = false)
		{
		}

		public void OnChangeOffBackground(bool force = false)
		{
		}

		public void OnChangeOffEffect(bool force = false)
		{
		}

		public void OnChangeLightMap(bool force = false)
		{
		}

		public void OnChangeShaderLodLevel(bool force = false)
		{
		}

		public void OnChangeObjectLodLevel(bool force = false)
		{
		}

		public void OnChangeReflection(bool force)
		{
		}

		public void OnChangeCharaShaderType(bool force)
		{
		}

		public void OnChangeAntiAliasing(bool force)
		{
		}

		public void GetCharaShaderKeywordFlag(CharaShaderParameter charaShaderParameter)
		{
		}
	}
}
