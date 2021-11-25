using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ActionTarget : IMaster<ActionTarget>
	{
		[SerializeField]
		private ActionTargetDictionary dict;

		public ActionTargetDictionary Dict => null;

		public SerializableDictionary<int, ActionTargetElement>.ValueCollection List => null;
	}
}
