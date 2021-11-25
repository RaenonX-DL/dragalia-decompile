using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class TutorialUnitSelect : IMaster<TutorialUnitSelect>
	{
		[SerializeField]
		private TutorialUnitSelectDictionary dict;

		public TutorialUnitSelectDictionary Dict => null;

		public SerializableDictionary<int, TutorialUnitSelectElement>.ValueCollection List => null;
	}
}
