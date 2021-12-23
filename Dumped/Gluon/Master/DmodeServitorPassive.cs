using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeServitorPassive : IMaster<DmodeServitorPassive>
	{
		[SerializeField]
		private DmodeServitorPassiveDictionary dict;

		public DmodeServitorPassiveDictionary Dict => null;

		public SerializableDictionary<int, DmodeServitorPassiveElement>.ValueCollection List => null;
	}
}
