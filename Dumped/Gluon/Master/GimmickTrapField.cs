using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickTrapField : IMaster<GimmickTrapField>
	{
		[SerializeField]
		private GimmickTrapFieldDictionary dict;

		public GimmickTrapFieldDictionary Dict => null;

		public SerializableDictionary<string, GimmickTrapFieldElement>.ValueCollection List => null;
	}
}
