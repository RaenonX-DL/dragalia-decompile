using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	public class MypageLimitedAreaNPC : IMaster<MypageLimitedAreaNPC>
	{
		[SerializeField]
		private MypageLimitedAreaNPCDictionary dict;

		public MypageLimitedAreaNPCDictionary Dict => null;

		public SerializableDictionary<int, MypageLimitedAreaNPCElement>.ValueCollection List => null;
	}
}
