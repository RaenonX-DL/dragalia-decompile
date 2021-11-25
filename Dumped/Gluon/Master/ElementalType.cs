using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ElementalType : IMaster<ElementalType>
	{
		[SerializeField]
		private ElementalTypeDictionary dict;

		public ElementalTypeDictionary Dict => null;

		public SerializableDictionary<int, ElementalTypeElement>.ValueCollection List => null;
	}
}
