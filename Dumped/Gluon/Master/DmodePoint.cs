using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodePoint : IMaster<DmodePoint>
	{
		[SerializeField]
		private DmodePointDictionary dict;

		public DmodePointDictionary Dict => null;

		public SerializableDictionary<int, DmodePointElement>.ValueCollection List => null;
	}
}
