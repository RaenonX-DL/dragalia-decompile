using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestMainMenu : IMaster<QuestMainMenu>
	{
		[SerializeField]
		private QuestMainMenuDictionary dict;

		public QuestMainMenuDictionary Dict => null;

		public SerializableDictionary<int, QuestMainMenuElement>.ValueCollection List => null;
	}
}
