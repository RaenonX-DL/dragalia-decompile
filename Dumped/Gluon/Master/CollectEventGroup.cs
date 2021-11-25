using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CollectEventGroup : IMasterGroupElement
	{
		[SerializeField]
		private CollectEventGroupDictionary dict;

		public CollectEventGroupDictionary Dict => null;

		public SerializableDictionary<int, CollectEventGroupElement>.ValueCollection List => null;
	}
}
