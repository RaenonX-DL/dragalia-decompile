using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeDungeonThemeBgm : IMaster<DmodeDungeonThemeBgm>
	{
		[SerializeField]
		private DmodeDungeonThemeBgmDictionary dict;

		public DmodeDungeonThemeBgmDictionary Dict => null;

		public SerializableDictionary<int, DmodeDungeonThemeBgmElement>.ValueCollection List => null;
	}
}
