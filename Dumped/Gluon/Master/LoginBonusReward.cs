using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LoginBonusReward : IMaster<LoginBonusReward>
	{
		[SerializeField]
		private LoginBonusRewardDictionary dict;

		public LoginBonusRewardDictionary Dict => null;

		public SerializableDictionary<int, LoginBonusRewardElement>.ValueCollection List => null;
	}
}
