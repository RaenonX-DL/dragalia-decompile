using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MissionAlbumData : IMaster<MissionAlbumData>
	{
		[SerializeField]
		private MissionAlbumDataDictionary dict;

		public MissionAlbumDataDictionary Dict => null;

		public SerializableDictionary<int, MissionAlbumDataElement>.ValueCollection List => null;
	}
}
