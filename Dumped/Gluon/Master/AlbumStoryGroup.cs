using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AlbumStoryGroup : IMaster<AlbumStoryGroup>
	{
		[SerializeField]
		private AlbumStoryGroupDictionary dict;

		public AlbumStoryGroupDictionary Dict => null;

		public SerializableDictionary<int, AlbumStoryGroupElement>.ValueCollection List => null;
	}
}
