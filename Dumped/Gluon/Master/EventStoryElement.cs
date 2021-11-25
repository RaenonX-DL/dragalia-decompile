using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private string _HiraganaPrinted;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private string _BannerImage;

		[SerializeField]
		private int _UnlockEventStoryId;

		[SerializeField]
		private int _UnlockQuestStoryId;

		[SerializeField]
		private GiftType _PayEntityType;

		[SerializeField]
		private int _PayEntityId;

		[SerializeField]
		private int _PayEntityQuantity;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public string Title => null;

		public int EventId => default(int);

		public int BaseId => default(int);

		public string HiraganaPrinted => null;

		public int VariationId => default(int);

		public string BannerImage => null;

		public int UnlockEventStoryId => default(int);

		public int UnlockQuestStoryId => default(int);

		public GiftType PayEntityType => default(GiftType);

		public int PayEntityId => default(int);

		public int PayEntityQuantity => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
