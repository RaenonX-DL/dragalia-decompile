using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class UserLevelDictionary : SerializableDictionary<int, UserLevelElement>
	{
	}
}
