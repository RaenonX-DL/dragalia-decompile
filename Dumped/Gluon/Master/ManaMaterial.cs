using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ManaMaterial : IMaster<ManaMaterial>
	{
		[SerializeField]
		private ManaMaterialDictionary dict;

		public ManaMaterialDictionary Dict => null;

		public SerializableDictionary<int, ManaMaterialElement>.ValueCollection List => null;
	}
}
