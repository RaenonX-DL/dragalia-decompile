using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortEnumsElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Num;

		[SerializeField]
		private float _FloatValue;

		public int Id => default(int);

		public int Num => default(int);

		public float FloatValue => default(float);
	}
}
