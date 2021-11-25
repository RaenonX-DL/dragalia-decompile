using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BuildEventReward : IMasterGroupElement
	{
		[SerializeField]
		private BuildEventRewardDictionary dict;

		public BuildEventRewardDictionary Dict => null;

		public SerializableDictionary<int, BuildEventRewardElement>.ValueCollection List => null;
	}
}
