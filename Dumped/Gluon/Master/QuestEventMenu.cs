using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestEventMenu : IMaster<QuestEventMenu>
	{
		[SerializeField]
		private QuestEventMenuDictionary dict;

		public QuestEventMenuDictionary Dict => null;

		public SerializableDictionary<int, QuestEventMenuElement>.ValueCollection List => null;
	}
}
