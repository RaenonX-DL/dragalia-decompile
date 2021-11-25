using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageLimitedAreaDictionary : SerializableDictionary<int, MyPageLimitedAreaElement>
	{
	}
}
