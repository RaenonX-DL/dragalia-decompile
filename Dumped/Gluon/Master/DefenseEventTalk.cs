using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DefenseEventTalk : IMaster<DefenseEventTalk>
	{
		[SerializeField]
		private DefenseEventTalkDictionary dict;

		public DefenseEventTalkDictionary Dict => null;

		public SerializableDictionary<int, DefenseEventTalkElement>.ValueCollection List => null;
	}
}
