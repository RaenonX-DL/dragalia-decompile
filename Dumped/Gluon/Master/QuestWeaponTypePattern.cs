using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class QuestWeaponTypePattern : IMaster<QuestWeaponTypePattern>
	{
		[SerializeField]
		private QuestWeaponTypePatternDictionary dict;

		public QuestWeaponTypePatternDictionary Dict => null;

		public SerializableDictionary<int, QuestWeaponTypePatternElement>.ValueCollection List => null;
	}
}
