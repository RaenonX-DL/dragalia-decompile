using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DungeonCharacterShaderDataElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _HeightColor;

		[SerializeField]
		private float _HeightTop;

		[SerializeField]
		private float _HeightBottom;

		[SerializeField]
		private float _HeightSoftness;

		[SerializeField]
		private float _Brightness;

		[SerializeField]
		private float _Saturation;

		[SerializeField]
		private float _Contrast;

		[SerializeField]
		private string _RimlightMaskMap;

		[SerializeField]
		private float _RimlightSize0;

		[SerializeField]
		private float _RimlightSoftness0;

		[SerializeField]
		private float _RimlightIntensity0;

		[SerializeField]
		private float _RimlightPower0;

		[SerializeField]
		private string _RimlightColor0;

		[SerializeField]
		private float _RimlightSize1;

		[SerializeField]
		private float _RimlightSoftness1;

		[SerializeField]
		private float _RimlightIntensity1;

		[SerializeField]
		private float _RimlightPower1;

		[SerializeField]
		private string _RimlightColor1;

		[SerializeField]
		private float _RimlightSize2;

		[SerializeField]
		private float _RimlightSoftness2;

		[SerializeField]
		private float _RimlightIntensity2;

		[SerializeField]
		private float _RimlightPower2;

		[SerializeField]
		private string _RimlightColor2;

		[SerializeField]
		private string _RichShaderData;

		public string Id => null;

		public string HeightColor => null;

		public float HeightTop => default(float);

		public float HeightBottom => default(float);

		public float HeightSoftness => default(float);

		public float Brightness => default(float);

		public float Saturation => default(float);

		public float Contrast => default(float);

		public string RimlightMaskMap => null;

		public float RimlightSize0 => default(float);

		public float RimlightSoftness0 => default(float);

		public float RimlightIntensity0 => default(float);

		public float RimlightPower0 => default(float);

		public string RimlightColor0 => null;

		public float RimlightSize1 => default(float);

		public float RimlightSoftness1 => default(float);

		public float RimlightIntensity1 => default(float);

		public float RimlightPower1 => default(float);

		public string RimlightColor1 => null;

		public float RimlightSize2 => default(float);

		public float RimlightSoftness2 => default(float);

		public float RimlightIntensity2 => default(float);

		public float RimlightPower2 => default(float);

		public string RimlightColor2 => null;

		public string RichShaderData => null;
	}
}
