using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CastleStory : IMaster<CastleStory>
	{
		[SerializeField]
		private CastleStoryDictionary dict;

		public CastleStoryDictionary Dict => null;

		public SerializableDictionary<int, CastleStoryElement>.ValueCollection List => null;
	}
}
