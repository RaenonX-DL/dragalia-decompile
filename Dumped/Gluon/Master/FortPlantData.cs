using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortPlantData : IMaster<FortPlantData>
	{
		[SerializeField]
		private FortPlantDataDictionary dict;

		public FortPlantDataDictionary Dict => null;

		public SerializableDictionary<int, FortPlantDataElement>.ValueCollection List => null;
	}
}
