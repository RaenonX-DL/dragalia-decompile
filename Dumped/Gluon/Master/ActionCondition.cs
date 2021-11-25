using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ActionCondition : IMaster<ActionCondition>
	{
		[SerializeField]
		private ActionConditionDictionary dict;

		public ActionConditionDictionary Dict => null;

		public SerializableDictionary<int, ActionConditionElement>.ValueCollection List => null;
	}
}
