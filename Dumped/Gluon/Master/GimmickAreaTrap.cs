using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class GimmickAreaTrap : IMaster<GimmickAreaTrap>
	{
		[SerializeField]
		private GimmickAreaTrapDictionary dict;

		public GimmickAreaTrapDictionary Dict => null;

		public SerializableDictionary<string, GimmickAreaTrapElement>.ValueCollection List => null;
	}
}
