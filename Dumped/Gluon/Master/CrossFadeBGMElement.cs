using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CrossFadeBGMElement : IMasterElement
	{
		[SerializeField]
		private string _CueName;

		[SerializeField]
		private float _FadeOutTime;

		[SerializeField]
		private float _FadeInTime;

		[SerializeField]
		private float _OffsetTime;

		public string CueName => null;

		public float FadeOutTime => default(float);

		public float FadeInTime => default(float);

		public float OffsetTime => default(float);
	}
}
