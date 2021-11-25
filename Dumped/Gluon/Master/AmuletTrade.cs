using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AmuletTrade : IMaster<AmuletTrade>
	{
		[SerializeField]
		private AmuletTradeDictionary dict;

		public AmuletTradeDictionary Dict => null;

		public SerializableDictionary<int, AmuletTradeElement>.ValueCollection List => null;
	}
}
