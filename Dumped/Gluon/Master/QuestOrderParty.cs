using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestOrderParty : IMaster<QuestOrderParty>
	{
		[SerializeField]
		private QuestOrderPartyDictionary dict;

		public QuestOrderPartyDictionary Dict => null;

		public SerializableDictionary<int, QuestOrderPartyElement>.ValueCollection List => null;
	}
}
