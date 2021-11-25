using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class CharaShaderParameter
	{
		[Serializable]
		public enum QualityLevel
		{
			None,
			Low,
			Middle,
			High
		}

		[Serializable]
		public class NormalAdjustmentColor
		{
			public float brightness;

			public float saturation;

			public float contrast;

			public NormalAdjustmentColor()
			{
			}

			public NormalAdjustmentColor(NormalAdjustmentColor src)
			{
			}

			public void Copy(NormalAdjustmentColor src)
			{
			}
		}

		[Serializable]
		public class NormalAdjustmentRim
		{
			public float size;

			public float softness;

			public float intensity;

			public float power;

			public Color color;

			public NormalAdjustmentRim()
			{
			}

			public NormalAdjustmentRim(NormalAdjustmentRim src)
			{
			}

			public void Copy(NormalAdjustmentRim src)
			{
			}
		}

		[Serializable]
		public class HeightColorParam
		{
			public float heightTop;

			public float heightBottom;

			public float softness;

			public Color color;

			public HeightColorParam(Color _color)
			{
			}

			public HeightColorParam(HeightColorParam src)
			{
			}

			public void Copy(HeightColorParam src)
			{
			}
		}

		public static readonly string[] QualityKeywords;

		public NormalAdjustmentColor[] normalAdjustmentColors;

		public HeightColorParam[] heightColorParams;

		[SerializeField]
		private Texture2D rimLightMaskMap;

		public NormalAdjustmentRim[] normalAdjustmentRims;

		public Texture2D RimLightMaskMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SceneRichShaderData sceneRichShaderData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void CreateNormalAdjustmentColors(int count)
		{
		}

		public void CopyParameters(CharaShaderParameter src)
		{
		}

		private int GetActiveColorChannel()
		{
			return default(int);
		}

		public void SetShaderParameter()
		{
		}
	}
}
