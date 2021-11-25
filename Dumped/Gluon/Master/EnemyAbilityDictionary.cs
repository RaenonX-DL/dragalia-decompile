using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyAbilityDictionary : SerializableDictionary<int, EnemyAbilityElement>
	{
	}
}
