using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TrackRecordType : IMaster<TrackRecordType>
	{
		[SerializeField]
		private TrackRecordTypeDictionary dict;

		public TrackRecordTypeDictionary Dict => null;

		public SerializableDictionary<int, TrackRecordTypeElement>.ValueCollection List => null;
	}
}
