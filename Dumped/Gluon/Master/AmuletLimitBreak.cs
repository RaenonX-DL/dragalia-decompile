using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class AmuletLimitBreak : IMaster<AmuletLimitBreak>
	{
		[SerializeField]
		private AmuletLimitBreakDictionary dict;

		public AmuletLimitBreakDictionary Dict => null;

		public SerializableDictionary<int, AmuletLimitBreakElement>.ValueCollection List => null;
	}
}
