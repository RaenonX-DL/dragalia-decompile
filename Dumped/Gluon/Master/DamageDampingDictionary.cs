using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class DamageDampingDictionary : SerializableDictionary<int, DamageDampingElement>
	{
	}
}
