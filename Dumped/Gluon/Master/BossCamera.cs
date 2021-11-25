using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BossCamera : IMaster<BossCamera>
	{
		[SerializeField]
		private BossCameraDictionary dict;

		public BossCameraDictionary Dict => null;

		public SerializableDictionary<int, BossCameraElement>.ValueCollection List => null;
	}
}
