using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RaidEventReward : IMasterGroupElement
	{
		[SerializeField]
		private RaidEventRewardDictionary dict;

		public RaidEventRewardDictionary Dict => null;

		public SerializableDictionary<int, RaidEventRewardElement>.ValueCollection List => null;
	}
}
