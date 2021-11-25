using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BossCameraElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _CameraAnimationName;

		[SerializeField]
		private float _BlurOn;

		[SerializeField]
		private float _BlurOff;

		public int Id => default(int);

		public string CameraAnimationName => null;

		public float BlurOn => default(float);

		public float BlurOff => default(float);
	}
}
