using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventDamageReward : IMasterGroupElement
	{
		[SerializeField]
		private EventDamageRewardDictionary dict;

		public EventDamageRewardDictionary Dict => null;

		public SerializableDictionary<int, EventDamageRewardElement>.ValueCollection List => null;
	}
}
