using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AmuletLevel : IMaster<AmuletLevel>
	{
		[SerializeField]
		private AmuletLevelDictionary dict;

		public AmuletLevelDictionary Dict => null;

		public SerializableDictionary<int, AmuletLevelElement>.ValueCollection List => null;
	}
}
