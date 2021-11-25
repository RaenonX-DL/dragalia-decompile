using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TrackRecordData : IMaster<TrackRecordData>
	{
		[SerializeField]
		private TrackRecordDataDictionary dict;

		public TrackRecordDataDictionary Dict => null;

		public SerializableDictionary<int, TrackRecordDataElement>.ValueCollection List => null;
	}
}
