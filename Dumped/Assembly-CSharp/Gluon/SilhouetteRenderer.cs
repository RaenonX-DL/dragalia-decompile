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
	public class SilhouetteRenderer : MonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		private float _silhouetteTextureScale;
		[SerializeField]
		private Color _SilhouetteRimColor;
		[SerializeField]
		private Color _SilhouetteBaseColor;
		[SerializeField]
		private Color _SilhouetteDisableColor;
		[Range]
		[SerializeField]
		private float _SilhouetteRimWidth;
		[Range]
		[SerializeField]
		private float _SilhouetteRimPower;
		[SerializeField]
		private SampleCount _SilhouetteSampleCount;
		private Camera _camera;
		private RenderTexture _renderTexture;
		private Shader _silhouetteBaseShader;
		private bool _enableSilhouette;
		private int _SilhouetteRimColorID;
		private int _SilhouetteBaseColorID;
		private int _SilhouetteRimWidthID;
		private int _SilhouetteRimPowerID;
		private int _SilhouetteTextureID;
	
		// Nested types
		[SerializeField]
		public enum SampleCount
		{
			Sample1 = 1,
			Sample2 = 2,
			Sample4 = 4,
			Sample8 = 8
		}
	
		// Constructors
		public SilhouetteRenderer();
	
		// Methods
		public void SetEnableSilhouette();
		public void SetDisableSilhouette();
		public void SetSilhouetteColor(Color baseColor, Color rimColor = default);
		private void SetShaderGlobalColorParam(Color rimColor, Color baseColor);
		private void CreateRenderTexture();
		private void SetSilhouetteParam();
		private void Start();
	}
}
