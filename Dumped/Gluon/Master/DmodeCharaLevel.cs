using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeCharaLevel : IMaster<DmodeCharaLevel>
	{
		[SerializeField]
		private DmodeCharaLevelDictionary dict;

		public DmodeCharaLevelDictionary Dict => null;

		public SerializableDictionary<int, DmodeCharaLevelElement>.ValueCollection List => null;
	}
}
