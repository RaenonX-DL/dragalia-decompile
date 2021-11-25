using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonLimitBreak : IMaster<DragonLimitBreak>
	{
		[SerializeField]
		private DragonLimitBreakDictionary dict;

		public DragonLimitBreakDictionary Dict => null;

		public SerializableDictionary<int, DragonLimitBreakElement>.ValueCollection List => null;
	}
}
