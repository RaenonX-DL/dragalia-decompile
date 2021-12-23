using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeSettingElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _MaxFloorNum;

		[SerializeField]
		private int _MaxDailySkipCount;

		[SerializeField]
		private int _MaxDailyRecoveryCount;

		[SerializeField]
		private int _DungeonScoreSystemMax;

		public int Id => default(int);

		public int MaxFloorNum => default(int);

		public int MaxDailySkipCount => default(int);

		public int MaxDailyRecoveryCount => default(int);

		public int DungeonScoreSystemMax => default(int);
	}
}
