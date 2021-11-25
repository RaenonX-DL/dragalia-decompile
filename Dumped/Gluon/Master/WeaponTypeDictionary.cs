using System;
using SerializableCollections;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponTypeDictionary : SerializableDictionary<int, WeaponTypeElement>
	{
	}
}
