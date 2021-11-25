using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class SystemMessageDictionary : SerializableDictionary<int, SystemMessageElement>
	{
	}
}
