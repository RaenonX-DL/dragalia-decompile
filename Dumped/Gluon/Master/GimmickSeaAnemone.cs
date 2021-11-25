using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickSeaAnemone : IMaster<GimmickSeaAnemone>
	{
		[SerializeField]
		private GimmickSeaAnemoneDictionary dict;

		public GimmickSeaAnemoneDictionary Dict => null;

		public SerializableDictionary<string, GimmickSeaAnemoneElement>.ValueCollection List => null;
	}
}
