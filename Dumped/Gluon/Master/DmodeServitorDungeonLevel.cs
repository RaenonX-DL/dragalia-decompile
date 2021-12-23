using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeServitorDungeonLevel : IMaster<DmodeServitorDungeonLevel>
	{
		[SerializeField]
		private DmodeServitorDungeonLevelDictionary dict;

		public DmodeServitorDungeonLevelDictionary Dict => null;

		public SerializableDictionary<int, DmodeServitorDungeonLevelElement>.ValueCollection List => null;
	}
}
