using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class ColorParam
	{
		public Color color;

		public float power;

		public ColorParam()
		{
		}

		public ColorParam(Color c, float p = 1f)
		{
		}

		public void Set(ColorParam param)
		{
		}

		public void Set(Color c, float p)
		{
		}

		public void SetLerpParam(ColorParam fromParam, ColorParam toParam, float ratio)
		{
		}
	}
}
