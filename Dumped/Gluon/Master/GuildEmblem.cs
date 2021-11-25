using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GuildEmblem : IMaster<GuildEmblem>
	{
		[SerializeField]
		private GuildEmblemDictionary dict;

		public GuildEmblemDictionary Dict => null;

		public SerializableDictionary<int, GuildEmblemElement>.ValueCollection List => null;
	}
}
