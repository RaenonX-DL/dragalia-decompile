using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BuffCountData : IMaster<BuffCountData>
	{
		[SerializeField]
		private BuffCountDataDictionary dict;

		public BuffCountDataDictionary Dict => null;

		public SerializableDictionary<int, BuffCountDataElement>.ValueCollection List => null;
	}
}
