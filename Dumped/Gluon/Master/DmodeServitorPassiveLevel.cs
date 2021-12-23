using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeServitorPassiveLevel : IMaster<DmodeServitorPassiveLevel>
	{
		[SerializeField]
		private DmodeServitorPassiveLevelDictionary dict;

		public DmodeServitorPassiveLevelDictionary Dict => null;

		public SerializableDictionary<int, DmodeServitorPassiveLevelElement>.ValueCollection List => null;
	}
}
