using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortPayListElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Costs;

		public int Id => default(int);

		public int Costs => default(int);
	}
}
