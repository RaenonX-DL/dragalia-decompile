using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeServitor : IMaster<DmodeServitor>
	{
		[SerializeField]
		private DmodeServitorDictionary dict;

		public DmodeServitorDictionary Dict => null;

		public SerializableDictionary<int, DmodeServitorElement>.ValueCollection List => null;
	}
}
