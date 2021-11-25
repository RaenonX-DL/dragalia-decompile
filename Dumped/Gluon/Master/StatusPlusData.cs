using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class StatusPlusData : IMaster<StatusPlusData>
	{
		[SerializeField]
		private StatusPlusDataDictionary dict;

		public StatusPlusDataDictionary Dict => null;

		public SerializableDictionary<int, StatusPlusDataElement>.ValueCollection List => null;
	}
}
