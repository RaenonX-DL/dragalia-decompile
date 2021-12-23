using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeEnemyTheme : IMaster<DmodeEnemyTheme>
	{
		[SerializeField]
		private DmodeEnemyThemeDictionary dict;

		public DmodeEnemyThemeDictionary Dict => null;

		public SerializableDictionary<int, DmodeEnemyThemeElement>.ValueCollection List => null;
	}
}
