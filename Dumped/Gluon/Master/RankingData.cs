using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RankingData : IMaster<RankingData>
	{
		[SerializeField]
		private RankingDataDictionary dict;

		public RankingDataDictionary Dict => null;

		public SerializableDictionary<int, RankingDataElement>.ValueCollection List => null;
	}
}
