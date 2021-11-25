using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BossCameraPosElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private float _PosX;

		[SerializeField]
		private float _PosZ;

		[SerializeField]
		private float _RotY;

		public int Id => default(int);

		public float PosX => default(float);

		public float PosZ => default(float);

		public float RotY => default(float);
	}
}
