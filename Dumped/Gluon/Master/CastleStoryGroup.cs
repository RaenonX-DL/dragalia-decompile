using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CastleStoryGroup : IMaster<CastleStoryGroup>
	{
		[SerializeField]
		private CastleStoryGroupDictionary dict;

		public CastleStoryGroupDictionary Dict => null;

		public SerializableDictionary<int, CastleStoryGroupElement>.ValueCollection List => null;
	}
}
