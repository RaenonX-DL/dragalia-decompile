using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyListDictionary : SerializableDictionary<int, EnemyListElement>
	{
	}
}
