using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CheatDetectionParam : IMaster<CheatDetectionParam>
	{
		[SerializeField]
		private CheatDetectionParamDictionary dict;

		public CheatDetectionParamDictionary Dict => null;

		public SerializableDictionary<int, CheatDetectionParamElement>.ValueCollection List => null;
	}
}
