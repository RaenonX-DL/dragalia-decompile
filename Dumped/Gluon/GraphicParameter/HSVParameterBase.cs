using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.GraphicParameter
{
	[Serializable]
	public class HSVParameterBase : IShaderData<HSVParameterBase>
	{
		[SerializeField]
		[Tooltip("è\u0089²ç\u009b\u00b8")]
		private float hue;

		[SerializeField]
		[Tooltip("å½©åº¦")]
		private float saturation;

		[SerializeField]
		[Tooltip("æ\u0098\u008eåº¦")]
		private float value;

		public Matrix4x4 parameterMatrix
		{
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float GetHue()
		{
			return default(float);
		}

		public void SetHue(float f)
		{
		}

		public float GetSaturation()
		{
			return default(float);
		}

		public void SetSaturation(float f)
		{
		}

		public float GetValue()
		{
			return default(float);
		}

		public void SetValue(float f)
		{
		}

		public bool isTrueColor()
		{
			return default(bool);
		}

		public virtual void UpdateParameterMatrix()
		{
		}

		public static void Lerp(ref HSVParameterBase o, HSVParameterBase a, HSVParameterBase b, float t)
		{
		}

		public void Copy(HSVParameterBase src)
		{
		}
	}
}
