using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LotteryData : IMaster<LotteryData>
	{
		[SerializeField]
		private LotteryDataDictionary dict;

		public LotteryDataDictionary Dict => null;

		public SerializableDictionary<int, LotteryDataElement>.ValueCollection List => null;
	}
}
