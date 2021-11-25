using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponLevelDictionary : SerializableDictionary<int, WeaponLevelElement>
	{
	}
}
