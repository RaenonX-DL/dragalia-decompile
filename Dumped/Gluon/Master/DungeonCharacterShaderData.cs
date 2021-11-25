using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DungeonCharacterShaderData : IMaster<DungeonCharacterShaderData>
	{
		[SerializeField]
		private DungeonCharacterShaderDataDictionary dict;

		public DungeonCharacterShaderDataDictionary Dict => null;

		public SerializableDictionary<string, DungeonCharacterShaderDataElement>.ValueCollection List => null;
	}
}
