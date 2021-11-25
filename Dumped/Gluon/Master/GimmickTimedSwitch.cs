using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickTimedSwitch : IMaster<GimmickTimedSwitch>
	{
		[SerializeField]
		private GimmickTimedSwitchDictionary dict;

		public GimmickTimedSwitchDictionary Dict => null;

		public SerializableDictionary<string, GimmickTimedSwitchElement>.ValueCollection List => null;
	}
}
