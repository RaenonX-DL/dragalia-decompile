/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePostEffectParams : MonoBehaviour
	{
		// Fields
		public FilterType filterType;
		public bool isDof;
		public bool isColorCollect;
		public bool isUseFog;
		public DofFocalType dofFocalType;
		public Transform dofFocalTransfrom;
		public Vector3 dofFocalPosition;
		public float dofFocalPoint;
		public float dofSmoothness;
		public float focalSize;
		public float maxForcalSize;
		public float dofMaxBlurSpread;
		[Range]
		public float bloomDofWeight;
		[Range]
		public float bloomThreshhold;
		[Range]
		public float bloomIntensity;
		[Range]
		public float bloomBlurSize;
		[Range]
		public int bloomBlurIterations;
		public bool isEnableBloom;
		public bool enableDofAutoDisable;
		public bool disableDofTemporary;
		public float diffusionBlurSize;
		public float bright;
		public float saturation;
		public float contrast;
		public PostFilmMode postFilmMode;
		public float postFilmPower;
		public Vector2 postFilmOffsetParam;
		public float vignetteIntensity;
		public float vignetteDecrement;
		public Color postFilmColor0;
		public Color postFilmColor1;
		public Color postFilmColor2;
		public Color postFilmColor3;
		[Range]
		public float blurArea;
		[Range]
		public float blurPower;
		[Range]
		public float blurOffset;
		[Range]
		public float blurBaseUp;
		[Range]
		public float lastGaussFilterBlurPower;
		[Range]
		public float lastGaussFilterBlurSize;
		public WorldIrisSetting[] worldIrisSetting;
		public PointIrisSetting[] pointIrisSettings;
		[Range]
		[SerializeField]
		public float pointIrisCutout;
		[Range]
		[SerializeField]
		public float bloomTextureScale;
		[SerializeField]
		public bool isTiltShiftDebug;
		public GaussType gaussVertical;
		public GaussType gaussHorizon;
		public Color fogColor;
		public float fogStartDistance;
		public float fogEndDistance;
	
		// Nested types
		[Serializable]
		public struct WorldIrisSetting
		{
			// Fields
			public Vector3 position;
			public float width;
			public float height;
		}
	
		[Serializable]
		public struct PointIrisSetting
		{
			// Fields
			[Range]
			public float pointIrisCenterX;
			[Range]
			public float pointIrisCenterY;
			[Range]
			public float pointIrisRadiusX;
			[Range]
			public float pointIrisRadiusY;
		}
	
		// Constructors
		public MyPagePostEffectParams();
	}
}
