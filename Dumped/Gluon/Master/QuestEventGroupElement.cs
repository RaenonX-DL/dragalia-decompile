using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestEventGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _EventViewName;

		[SerializeField]
		private int _BaseQuestGroupId;

		[SerializeField]
		private int _SortKey;

		[SerializeField]
		private QuestGroupIntervalType _QuestGroupIntervalType;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private int _IsViewSoloMultiTab;

		[SerializeField]
		private int _IsHideBanner;

		[SerializeField]
		private int _NoticeDayCount;

		[SerializeField]
		private int _FirstViewQuestStory;

		[SerializeField]
		private int _SoloSearchClearPartyTabCount;

		[SerializeField]
		private string _SoloSearchClearPartyTabTitle;

		[SerializeField]
		private string _SoloSearchClearPartyTabName1;

		[SerializeField]
		private string _SoloSearchClearPartyTabName2;

		[SerializeField]
		private string _SoloSearchClearPartyTabName3;

		[SerializeField]
		private string _SoloSearchClearPartyTabName4;

		[SerializeField]
		private int _MultiSearchClearPartyTabCount;

		[SerializeField]
		private string _MultiSearchClearPartyTabTitle;

		[SerializeField]
		private string _MultiSearchClearPartyTabName1;

		[SerializeField]
		private string _MultiSearchClearPartyTabName2;

		[SerializeField]
		private string _MultiSearchClearPartyTabName3;

		[SerializeField]
		private string _MultiSearchClearPartyTabName4;

		public int Id => default(int);

		public string EventViewName => null;

		public int BaseQuestGroupId => default(int);

		public int SortKey => default(int);

		public QuestGroupIntervalType QuestGroupIntervalType => default(QuestGroupIntervalType);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public int IsViewSoloMultiTab => default(int);

		public int IsHideBanner => default(int);

		public int NoticeDayCount => default(int);

		public int FirstViewQuestStory => default(int);

		public int SoloSearchClearPartyTabCount => default(int);

		public string SoloSearchClearPartyTabTitle => null;

		public string SoloSearchClearPartyTabName1 => null;

		public string SoloSearchClearPartyTabName2 => null;

		public string SoloSearchClearPartyTabName3 => null;

		public string SoloSearchClearPartyTabName4 => null;

		public int MultiSearchClearPartyTabCount => default(int);

		public string MultiSearchClearPartyTabTitle => null;

		public string MultiSearchClearPartyTabName1 => null;

		public string MultiSearchClearPartyTabName2 => null;

		public string MultiSearchClearPartyTabName3 => null;

		public string MultiSearchClearPartyTabName4 => null;
	}
}
