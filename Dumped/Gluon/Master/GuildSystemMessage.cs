using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GuildSystemMessage : IMaster<GuildSystemMessage>
	{
		[SerializeField]
		private GuildSystemMessageDictionary dict;

		public GuildSystemMessageDictionary Dict => null;

		public SerializableDictionary<int, GuildSystemMessageElement>.ValueCollection List => null;
	}
}
