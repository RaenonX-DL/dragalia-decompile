using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class BossCameraPos : IMaster<BossCameraPos>
	{
		[SerializeField]
		private BossCameraPosDictionary dict;

		public BossCameraPosDictionary Dict => null;

		public SerializableDictionary<int, BossCameraPosElement>.ValueCollection List => null;
	}
}
