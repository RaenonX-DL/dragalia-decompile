using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventCyclePointReward : IMasterGroupElement
	{
		[SerializeField]
		private EventCyclePointRewardDictionary dict;

		public EventCyclePointRewardDictionary Dict => null;

		public SerializableDictionary<int, EventCyclePointRewardElement>.ValueCollection List => null;
	}
}
