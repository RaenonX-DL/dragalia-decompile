using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class Clb01EventItem : IMaster<Clb01EventItem>
	{
		[SerializeField]
		private Clb01EventItemDictionary dict;

		public Clb01EventItemDictionary Dict => null;

		public SerializableDictionary<int, Clb01EventItemElement>.ValueCollection List => null;
	}
}
