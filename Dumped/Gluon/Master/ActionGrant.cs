using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ActionGrant : IMaster<ActionGrant>
	{
		[SerializeField]
		private ActionGrantDictionary dict;

		public ActionGrantDictionary Dict => null;

		public SerializableDictionary<int, ActionGrantElement>.ValueCollection List => null;
	}
}
