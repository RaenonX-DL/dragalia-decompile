using System;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventSchedule : IMasterGroupElement
	{
		[SerializeField]
		private MazeEventScheduleDictionary dict;

		public MazeEventScheduleDictionary Dict => null;

		public SerializableDictionary<int, MazeEventScheduleElement>.ValueCollection List => null;
	}
}
