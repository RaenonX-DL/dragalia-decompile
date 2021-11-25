using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class StampDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _InfoMsg;

		[SerializeField]
		private string _VoiceId;

		[SerializeField]
		private GiftType _DuplicateEntityType;

		[SerializeField]
		private int _DuplicateEntityId;

		[SerializeField]
		private int _DuplicateEntityQuantity;

		public int Id => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public int SortId => default(int);

		public string Title => null;

		public string InfoMsg => null;

		public string VoiceId => null;

		public GiftType DuplicateEntityType => default(GiftType);

		public int DuplicateEntityId => default(int);

		public int DuplicateEntityQuantity => default(int);
	}
}
