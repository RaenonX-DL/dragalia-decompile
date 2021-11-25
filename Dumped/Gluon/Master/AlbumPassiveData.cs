using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AlbumPassiveData : IMaster<AlbumPassiveData>
	{
		[SerializeField]
		private AlbumPassiveDataDictionary dict;

		public AlbumPassiveDataDictionary Dict => null;

		public SerializableDictionary<int, AlbumPassiveDataElement>.ValueCollection List => null;
	}
}
