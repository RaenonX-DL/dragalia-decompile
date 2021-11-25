using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DefaultGraphicSetting : IMaster<DefaultGraphicSetting>
	{
		[SerializeField]
		private DefaultGraphicSettingDictionary dict;

		public DefaultGraphicSettingDictionary Dict => null;

		public SerializableDictionary<int, DefaultGraphicSettingElement>.ValueCollection List => null;
	}
}
