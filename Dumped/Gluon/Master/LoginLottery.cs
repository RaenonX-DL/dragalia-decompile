using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class LoginLottery : IMaster<LoginLottery>
	{
		[SerializeField]
		private LoginLotteryDictionary dict;

		public LoginLotteryDictionary Dict => null;

		public SerializableDictionary<int, LoginLotteryElement>.ValueCollection List => null;
	}
}
