using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class LotteryDataDictionary : SerializableDictionary<int, LotteryDataElement>
	{
	}
}
