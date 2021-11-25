using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class LoginBonusDataDictionary : SerializableDictionary<int, LoginBonusDataElement>
	{
	}
}
