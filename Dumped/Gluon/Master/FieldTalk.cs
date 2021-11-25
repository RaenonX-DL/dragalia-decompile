using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class FieldTalk : IMaster<FieldTalk>
	{
		[SerializeField]
		private FieldTalkDictionary dict;

		public FieldTalkDictionary Dict => null;

		public SerializableDictionary<int, FieldTalkElement>.ValueCollection List => null;
	}
}
