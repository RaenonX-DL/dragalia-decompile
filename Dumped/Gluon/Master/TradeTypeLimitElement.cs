using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TradeTypeLimitElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TradeLimitValue;

		public int Id => default(int);

		public int TradeLimitValue => default(int);
	}
}
