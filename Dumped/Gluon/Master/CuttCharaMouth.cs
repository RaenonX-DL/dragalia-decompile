using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CuttCharaMouth : IMaster<CuttCharaMouth>
	{
		[SerializeField]
		private CuttCharaMouthDictionary dict;

		public CuttCharaMouthDictionary Dict => null;

		public SerializableDictionary<int, CuttCharaMouthElement>.ValueCollection List => null;
	}
}
