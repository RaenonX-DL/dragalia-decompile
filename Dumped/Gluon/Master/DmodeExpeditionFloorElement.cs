using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeExpeditionFloorElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _FloorNum;

		[SerializeField]
		private string _ReleaseStartDate;

		[SerializeField]
		private int _NeedTime;

		[SerializeField]
		private int _RewardDmodePoint1;

		[SerializeField]
		private int _RewardDmodePoint2;

		public int Id => default(int);

		public int FloorNum => default(int);

		public string ReleaseStartDate => null;

		public int NeedTime => default(int);

		public int RewardDmodePoint1 => default(int);

		public int RewardDmodePoint2 => default(int);
	}
}
