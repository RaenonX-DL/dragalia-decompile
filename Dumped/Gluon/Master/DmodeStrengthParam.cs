using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class DmodeStrengthParam : IMaster<DmodeStrengthParam>
	{
		[SerializeField]
		private DmodeStrengthParamDictionary dict;

		public DmodeStrengthParamDictionary Dict => null;

		public SerializableDictionary<int, DmodeStrengthParamElement>.ValueCollection List => null;
	}
}
