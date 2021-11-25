using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ActionCollision : IMaster<ActionCollision>
	{
		[SerializeField]
		private ActionCollisionDictionary dict;

		public ActionCollisionDictionary Dict => null;

		public SerializableDictionary<int, ActionCollisionElement>.ValueCollection List => null;
	}
}
