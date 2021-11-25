using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AlbumStory : IMaster<AlbumStory>
	{
		[SerializeField]
		private AlbumStoryDictionary dict;

		public AlbumStoryDictionary Dict => null;

		public SerializableDictionary<int, AlbumStoryElement>.ValueCollection List => null;
	}
}
