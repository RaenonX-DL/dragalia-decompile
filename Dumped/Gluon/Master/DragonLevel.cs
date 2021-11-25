using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonLevel : IMaster<DragonLevel>
	{
		[SerializeField]
		private DragonLevelDictionary dict;

		public DragonLevelDictionary Dict => null;

		public SerializableDictionary<int, DragonLevelElement>.ValueCollection List => null;
	}
}
