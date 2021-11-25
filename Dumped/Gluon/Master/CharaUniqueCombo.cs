using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class CharaUniqueCombo : IMaster<CharaUniqueCombo>
	{
		[SerializeField]
		private CharaUniqueComboDictionary dict;

		public CharaUniqueComboDictionary Dict => null;

		public SerializableDictionary<int, CharaUniqueComboElement>.ValueCollection List => null;
	}
}
