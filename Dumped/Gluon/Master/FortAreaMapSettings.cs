using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FortAreaMapSettings : IMaster<FortAreaMapSettings>
	{
		[SerializeField]
		private FortAreaMapSettingsDictionary dict;

		public FortAreaMapSettingsDictionary Dict => null;

		public SerializableDictionary<int, FortAreaMapSettingsElement>.ValueCollection List => null;
	}
}
