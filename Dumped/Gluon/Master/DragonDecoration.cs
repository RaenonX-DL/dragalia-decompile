using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DragonDecoration : IMaster<DragonDecoration>
	{
		[SerializeField]
		private DragonDecorationDictionary dict;

		public DragonDecorationDictionary Dict => null;

		public SerializableDictionary<int, DragonDecorationElement>.ValueCollection List => null;
	}
}
