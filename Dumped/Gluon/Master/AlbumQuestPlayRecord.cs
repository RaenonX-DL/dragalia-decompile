using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AlbumQuestPlayRecord : IMaster<AlbumQuestPlayRecord>
	{
		[SerializeField]
		private AlbumQuestPlayRecordDictionary dict;

		public AlbumQuestPlayRecordDictionary Dict => null;

		public SerializableDictionary<int, AlbumQuestPlayRecordElement>.ValueCollection List => null;
	}
}
