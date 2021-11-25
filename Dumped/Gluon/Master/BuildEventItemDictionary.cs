using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventItemDictionary : SerializableDictionary<int, BuildEventItemElement>
	{
	}
}
