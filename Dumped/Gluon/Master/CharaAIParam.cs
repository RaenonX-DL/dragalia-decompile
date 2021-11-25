using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaAIParam : IMaster<CharaAIParam>
	{
		[SerializeField]
		private CharaAIParamDictionary dict;

		public CharaAIParamDictionary Dict => null;

		public SerializableDictionary<int, CharaAIParamElement>.ValueCollection List => null;
	}
}
