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
		[Header]
		[Tooltip]
		public FilterType filterType;
		public bool isColorCollect;
		public bool isUseFog;
		[Header]
		[Tooltip]
		public bool isDof;
		[Tooltip]
		public DofFocalType dofFocalType;
		[Tooltip]
		public Transform dofFocalTransfrom;
		[Tooltip]
		public Vector3 dofFocalPosition;
		[Tooltip]
		public float dofFocalPoint;
		[Tooltip]
		public float dofSmoothness;
		[Tooltip]
		public float focalSize;
		[Header]
		[Tooltip]
		public bool isEnableBloom;
		[Range]
		[Tooltip]
		public float bloomDofWeight;
		[Range]
		[Tooltip]
		public float bloomThreshhold;
		[Range]
		[Tooltip]
		public float bloomIntensity;
		[Range]
		[SerializeField]
		[Tooltip]
		public float bloomTextureScale;
		[Header]
		[Range]
		[Tooltip]
		public float diffusionBlurSize;
		[Range]
		[Tooltip]
		public float bright;
		[Range]
		[Tooltip]
		public float saturation;
		[Range]
		[Tooltip]
		public float contrast;
		[Header]
		[Tooltip]
		public PostFilmMode postFilmMode;
		[Tooltip]
		public float postFilmPower;
		[Tooltip]
		public Vector2 postFilmOffsetParam;
		[Tooltip]
		public float vignetteIntensity;
		[Tooltip]
		public float vignetteDecrement;
		[Tooltip]
		public Color postFilmColor0;
		[Tooltip]
		public Color postFilmColor1;
		[Tooltip]
		public Color postFilmColor2;
		[Tooltip]
		public Color postFilmColor3;
		[Header]
		[Range]
		[Tooltip]
		public float blurArea;
		[Range]
		[Tooltip]
		public float blurPower;
		[Range]
		[Tooltip]
		public float blurOffset;
		[Range]
		[Tooltip]
		public float blurBaseUp;
		public WorldIrisSetting[] worldIrisSetting;
		public PointIrisSetting[] pointIrisSettings;
		[Range]
		[SerializeField]
		[Tooltip]
		public float pointIrisCutout;
		[Tooltip]
		public bool isTiltShiftDebug;
		[Header]
		[Tooltip]
		public GaussType gaussVertical;
		[Tooltip]
		public GaussType gaussHorizon;
		[Range]
		[Tooltip]
		public float lastGaussFilterBlurPower;
		[Range]
		[Tooltip]
		public float lastGaussFilterBlurSize;
		[Header]
		[Tooltip]
		public Color fogColor;
		[Tooltip]
		public float fogStartDistance;
		[Tooltip]
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
