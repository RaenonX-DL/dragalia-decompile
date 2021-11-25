using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class GuildSystemMessageDictionary : SerializableDictionary<int, GuildSystemMessageElement>
	{
	}
}
