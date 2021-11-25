using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class UnitStory : IMaster<UnitStory>
	{
		[SerializeField]
		private UnitStoryDictionary dict;

		public UnitStoryDictionary Dict => null;

		public SerializableDictionary<int, UnitStoryElement>.ValueCollection List => null;
	}
}
