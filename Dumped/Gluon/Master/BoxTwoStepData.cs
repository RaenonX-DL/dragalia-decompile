using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BoxTwoStepData : IMaster<BoxTwoStepData>
	{
		[SerializeField]
		private BoxTwoStepDataDictionary dict;

		public BoxTwoStepDataDictionary Dict => null;

		public SerializableDictionary<int, BoxTwoStepDataElement>.ValueCollection List => null;
	}
}
