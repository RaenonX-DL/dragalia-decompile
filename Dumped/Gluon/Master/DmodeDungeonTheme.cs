using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeDungeonTheme : IMaster<DmodeDungeonTheme>
	{
		[SerializeField]
		private DmodeDungeonThemeDictionary dict;

		public DmodeDungeonThemeDictionary Dict => null;

		public SerializableDictionary<int, DmodeDungeonThemeElement>.ValueCollection List => null;
	}
}
