/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class CharaShaderParameter
	{
		// Fields
		public static readonly string[] QualityKeywords;
		public NormalAdjustmentColor[] normalAdjustmentColors;
		public HeightColorParam[] heightColorParams;
		[SerializeField]
		private Texture2D rimLightMaskMap;
		public NormalAdjustmentRim[] normalAdjustmentRims;
		[CompilerGenerated]
		private SceneRichShaderData _sceneRichShaderData_k__BackingField;
	
		// Properties
		public Texture2D RimLightMaskMap { get; set; }
		public SceneRichShaderData sceneRichShaderData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		public enum QualityLevel
		{
			None = 0,
			Low = 1,
			Middle = 2,
			High = 3
		}
	
		[Serializable]
		public class NormalAdjustmentColor
		{
			// Fields
			[Range]
			public float brightness;
			[Range]
			public float saturation;
			[Range]
			public float contrast;
	
			// Constructors
			public NormalAdjustmentColor();
			public NormalAdjustmentColor(NormalAdjustmentColor src);
	
			// Methods
			public void Copy(NormalAdjustmentColor src);
		}
	
		[Serializable]
		public class NormalAdjustmentRim
		{
			// Fields
			[Range]
			public float size;
			[Range]
			public float softness;
			[Range]
			public float intensity;
			[Range]
			public float power;
			public Color color;
	
			// Constructors
			public NormalAdjustmentRim();
			public NormalAdjustmentRim(NormalAdjustmentRim src);
	
			// Methods
			public void Copy(NormalAdjustmentRim src);
		}
	
		[Serializable]
		public class HeightColorParam
		{
			// Fields
			[Range]
			public float heightTop;
			[Range]
			public float heightBottom;
			[Range]
			public float softness;
			public Color color;
	
			// Constructors
			public HeightColorParam(Color _color);
			public HeightColorParam(HeightColorParam src);
	
			// Methods
			public void Copy(HeightColorParam src);
		}
	
		// Constructors
		public CharaShaderParameter();
		static CharaShaderParameter();
	
		// Methods
		public void CreateNormalAdjustmentColors(int count);
		public void CopyParameters(CharaShaderParameter src);
		private int GetActiveColorChannel();
		public void SetShaderParameter();
	}
}
