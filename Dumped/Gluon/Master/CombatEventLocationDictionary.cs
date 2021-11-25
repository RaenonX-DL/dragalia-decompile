using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class CombatEventLocationDictionary : SerializableDictionary<int, CombatEventLocationElement>
	{
	}
}
