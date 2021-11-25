using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyLevelHitDictionary : SerializableDictionary<int, EnemyLevelHitElement>
	{
	}
}
