using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaLimitBreak : IMaster<CharaLimitBreak>
	{
		[SerializeField]
		private CharaLimitBreakDictionary dict;

		public CharaLimitBreakDictionary Dict => null;

		public SerializableDictionary<int, CharaLimitBreakElement>.ValueCollection List => null;
	}
}
