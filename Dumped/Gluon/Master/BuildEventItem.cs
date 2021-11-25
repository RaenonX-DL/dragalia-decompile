using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BuildEventItem : IMaster<BuildEventItem>
	{
		[SerializeField]
		private BuildEventItemDictionary dict;

		public BuildEventItemDictionary Dict => null;

		public SerializableDictionary<int, BuildEventItemElement>.ValueCollection List => null;
	}
}
