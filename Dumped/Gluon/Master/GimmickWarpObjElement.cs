using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickWarpObjElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private float _Radius;

		[SerializeField]
		private float _Delay;

		public string Id => null;

		public float Radius => default(float);

		public float Delay => default(float);
	}
}
