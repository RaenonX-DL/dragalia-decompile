using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GimmickDurablePillarElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private int _DurablePoint;

		public string Id => null;

		public int DurablePoint => default(int);
	}
}
