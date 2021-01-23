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
	[CreateAssetMenu]
	public class SceneRichShaderData : ScriptableObject, IShaderData<Gluon.SceneRichShaderData>
	{
		// Fields
		[Tooltip]
		public ToonShadingData toonShadingData;
		[Tooltip]
		public OutlineData outlineData;
		private ToonShadingData startToonShadingData;
		private OutlineData startOutlineData;
	
		// Nested types
		[Serializable]
		public class ShadowParam : IShaderData<ShadowParam>
		{
			// Fields
			[Range]
			[Tooltip]
			public float step;
			[Range]
			[Tooltip]
			public float feather;
	
			// Constructors
			public ShadowParam();
	
			// Methods
			public void Copy(ShadowParam src);
		}
	
		[Serializable]
		public class ToonShadingData : IShaderData<ToonShadingData>
		{
			// Fields
			[Tooltip]
			public Color toonGlobalShadowColor;
			[Tooltip]
			public Color toonGlobalShadowGlowColor;
			[Tooltip]
			public HSVParameterBase toonCommonEdgeShadowHSV;
			[Tooltip]
			public Vector3 toonLightParamRoatate;
			[Tooltip]
			public Texture2D matcapProjectionTex;
			[Range]
			[Tooltip]
			public float matcapProjectionTexLevel;
			[Tooltip]
			public Color matcapProjectionColor;
			[Range]
			[Tooltip]
			public float matcapProjectionIntensity;
			[Tooltip]
			public ShadowParam shadowToon;
			[Tooltip]
			public ShadowParam shadowEdge;
			[Tooltip]
			public ShadowParam shadowGlow;
	
			// Constructors
			public ToonShadingData();
	
			// Methods
			public void Copy(ToonShadingData src);
		}
	
		[Serializable]
		public class OutlineData : IShaderData<OutlineData>
		{
			// Fields
			[Tooltip]
			public Color color;
			[Range]
			[Tooltip]
			public float width;
			[Tooltip]
			public float widthClampMin;
			[Tooltip]
			public float widthClampMax;
			[Tooltip]
			public float offset;
	
			// Constructors
			public OutlineData();
	
			// Methods
			public void Copy(OutlineData src);
		}
	
		// Constructors
		public SceneRichShaderData();
	
		// Methods
		public void Copy(SceneRichShaderData src);
		public void Reset();
		private void Awake();
	}
}
