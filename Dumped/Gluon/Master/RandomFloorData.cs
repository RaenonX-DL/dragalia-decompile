using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RandomFloorData : IMaster<RandomFloorData>
	{
		[SerializeField]
		private RandomFloorDataDictionary dict;

		public RandomFloorDataDictionary Dict => null;

		public SerializableDictionary<int, RandomFloorDataElement>.ValueCollection List => null;
	}
}
