using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BuffExplosionData : IMaster<BuffExplosionData>
	{
		[SerializeField]
		private BuffExplosionDataDictionary dict;

		public BuffExplosionDataDictionary Dict => null;

		public SerializableDictionary<int, BuffExplosionDataElement>.ValueCollection List => null;
	}
}
