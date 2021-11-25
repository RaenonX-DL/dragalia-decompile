using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LoginBonusData : IMaster<LoginBonusData>
	{
		[SerializeField]
		private LoginBonusDataDictionary dict;

		public LoginBonusDataDictionary Dict => null;

		public SerializableDictionary<int, LoginBonusDataElement>.ValueCollection List => null;
	}
}
