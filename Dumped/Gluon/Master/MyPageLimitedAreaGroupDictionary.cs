using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageLimitedAreaGroupDictionary : SerializableDictionary<int, MyPageLimitedAreaGroupElement>
	{
	}
}
