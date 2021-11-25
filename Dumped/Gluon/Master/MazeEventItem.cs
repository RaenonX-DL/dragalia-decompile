using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MazeEventItem : IMaster<MazeEventItem>
	{
		[SerializeField]
		private MazeEventItemDictionary dict;

		public MazeEventItemDictionary Dict => null;

		public SerializableDictionary<int, MazeEventItemElement>.ValueCollection List => null;
	}
}
