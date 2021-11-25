using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaLevel : IMaster<CharaLevel>
	{
		[SerializeField]
		private CharaLevelDictionary dict;

		public CharaLevelDictionary Dict => null;

		public SerializableDictionary<int, CharaLevelElement>.ValueCollection List => null;
	}
}
