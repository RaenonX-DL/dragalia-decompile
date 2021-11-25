using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponRarityDictionary : SerializableDictionary<int, WeaponRarityElement>
	{
	}
}
