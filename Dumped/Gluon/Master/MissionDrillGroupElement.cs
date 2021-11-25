using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MissionDrillGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _TextName;

		[SerializeField]
		private string _TextNameShort;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private string _TextTitle;

		[SerializeField]
		private string _TextDetail;

		[SerializeField]
		private GiftType _UnlockEntityType1;

		[SerializeField]
		private int _UnlockEntityId1;

		[SerializeField]
		private int _UnlockEntityQuantity1;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public string TextName => null;

		public string TextNameShort => null;

		public int Step => default(int);

		public string TextTitle => null;

		public string TextDetail => null;

		public GiftType UnlockEntityType1 => default(GiftType);

		public int UnlockEntityId1 => default(int);

		public int UnlockEntityQuantity1 => default(int);

		public string StartDate => null;

		public string EndDate => null;
	}
}
