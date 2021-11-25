using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonData : IMaster<DragonData>
	{
		[SerializeField]
		private DragonDataDictionary dict;

		public DragonDataDictionary Dict => null;

		public SerializableDictionary<int, DragonDataElement>.ValueCollection List => null;
	}
}
