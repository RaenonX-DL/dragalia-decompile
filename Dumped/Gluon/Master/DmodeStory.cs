using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeStory : IMaster<DmodeStory>
	{
		[SerializeField]
		private DmodeStoryDictionary dict;

		public DmodeStoryDictionary Dict => null;

		public SerializableDictionary<int, DmodeStoryElement>.ValueCollection List => null;
	}
}
