using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TutorialUnitSelectList : IMaster<TutorialUnitSelectList>
	{
		[SerializeField]
		private TutorialUnitSelectListDictionary dict;

		public TutorialUnitSelectListDictionary Dict => null;

		public SerializableDictionary<int, TutorialUnitSelectListElement>.ValueCollection List => null;
	}
}
