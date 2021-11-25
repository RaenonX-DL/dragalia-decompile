using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RankingGroupData : IMaster<RankingGroupData>
	{
		[SerializeField]
		private RankingGroupDataDictionary dict;

		public RankingGroupDataDictionary Dict => null;

		public SerializableDictionary<int, RankingGroupDataElement>.ValueCollection List => null;
	}
}
