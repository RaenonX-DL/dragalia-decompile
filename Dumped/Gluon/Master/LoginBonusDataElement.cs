using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class LoginBonusDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _LoginBonusName;

		[SerializeField]
		private int _IsLoop;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _StartTime;

		[SerializeField]
		private string _EndTime;

		[SerializeField]
		private GiftType _EachDayEntityType;

		[SerializeField]
		private int _EachDayEntityId;

		[SerializeField]
		private int _EachDayEntityQuantity;

		public int Id => default(int);

		public string LoginBonusName => null;

		public int IsLoop => default(int);

		public int SortId => default(int);

		public string StartTime => null;

		public string EndTime => null;

		public GiftType EachDayEntityType => default(GiftType);

		public int EachDayEntityId => default(int);

		public int EachDayEntityQuantity => default(int);
	}
}
