using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class ActionMarker : IMaster<ActionMarker>
	{
		[SerializeField]
		private ActionMarkerDictionary dict;

		public ActionMarkerDictionary Dict => null;

		public SerializableDictionary<int, ActionMarkerElement>.ValueCollection List => null;
	}
}
