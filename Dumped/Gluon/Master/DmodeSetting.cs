using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeSetting : IMaster<DmodeSetting>
	{
		[SerializeField]
		private DmodeSettingDictionary dict;

		public DmodeSettingDictionary Dict => null;

		public SerializableDictionary<int, DmodeSettingElement>.ValueCollection List => null;
	}
}
