using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class PriceChangeDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _PriceChangeType;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private int _PaymentType;

		[SerializeField]
		private int _NeedCost;

		public int Id => default(int);

		public int PriceChangeType => default(int);

		public int Step => default(int);

		public int PaymentType => default(int);

		public int NeedCost => default(int);
	}
}
