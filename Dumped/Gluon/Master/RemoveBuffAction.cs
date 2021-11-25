using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class RemoveBuffAction : IMaster<RemoveBuffAction>
	{
		[SerializeField]
		private RemoveBuffActionDictionary dict;

		public RemoveBuffActionDictionary Dict => null;

		public SerializableDictionary<int, RemoveBuffActionElement>.ValueCollection List => null;
	}
}
