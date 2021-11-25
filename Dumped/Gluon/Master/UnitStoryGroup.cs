using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class UnitStoryGroup : IMaster<UnitStoryGroup>
	{
		[SerializeField]
		private UnitStoryGroupDictionary dict;

		public UnitStoryGroupDictionary Dict => null;

		public SerializableDictionary<int, UnitStoryGroupElement>.ValueCollection List => null;
	}
}
