using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventReward : IMasterGroupElement
	{
		[SerializeField]
		private MazeEventRewardDictionary dict;

		public MazeEventRewardDictionary Dict => null;

		public SerializableDictionary<int, MazeEventRewardElement>.ValueCollection List => null;
	}
}
