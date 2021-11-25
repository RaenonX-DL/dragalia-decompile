using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class BoxSummonDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private int _EventItemId;

		[SerializeField]
		private int _CostNum;

		[SerializeField]
		private GiftType _ResetEntityType;

		[SerializeField]
		private int _ResetEntityId;

		[SerializeField]
		private int _SequenceCount;

		public int Id => default(int);

		public int Priority => default(int);

		public int EventId => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public int EventItemId => default(int);

		public int CostNum => default(int);

		public GiftType ResetEntityType => default(GiftType);

		public int ResetEntityId => default(int);

		public int SequenceCount => default(int);
	}
}
