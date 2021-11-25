using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaAIParamElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ComboMaxProb;

		[SerializeField]
		private float _GridSize;

		public int Id => default(int);

		public int ComboMaxProb => default(int);

		public float GridSize => default(float);
	}
}
