using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaAIOperation : IMaster<CharaAIOperation>
	{
		[SerializeField]
		private CharaAIOperationDictionary dict;

		public CharaAIOperationDictionary Dict => null;

		public SerializableDictionary<int, CharaAIOperationElement>.ValueCollection List => null;
	}
}
