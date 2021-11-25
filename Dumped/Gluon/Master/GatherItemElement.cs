using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GatherItemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Detail;

		[SerializeField]
		private int _QuestWeeklyTakeLimit;

		public int Id => default(int);

		public string Name => null;

		public string Detail => null;

		public int QuestWeeklyTakeLimit => default(int);
	}
}
