using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortPlantDetail : IMaster<FortPlantDetail>
	{
		[SerializeField]
		private FortPlantDetailDictionary dict;

		public FortPlantDetailDictionary Dict => null;

		public SerializableDictionary<int, FortPlantDetailElement>.ValueCollection List => null;
	}
}
