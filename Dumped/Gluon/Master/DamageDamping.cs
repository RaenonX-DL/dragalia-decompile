using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DamageDamping : IMaster<DamageDamping>
	{
		[SerializeField]
		private DamageDampingDictionary dict;

		public DamageDampingDictionary Dict => null;

		public SerializableDictionary<int, DamageDampingElement>.ValueCollection List => null;
	}
}
