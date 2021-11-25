using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestEventElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _EventViewName;

		[SerializeField]
		private int _ShowCatetory;

		[SerializeField]
		private int _UpsideCategory;

		[SerializeField]
		private int _SortKey;

		[SerializeField]
		private QuestEventType _QuestEventType;

		[SerializeField]
		private int _QuestRibbonImageNo;

		[SerializeField]
		private int _IsViewSoloMultiTab;

		[SerializeField]
		private int _IsHeaderQuest;

		[SerializeField]
		private int _InformationId;

		[SerializeField]
		private int _IsViewNewBadge;

		[SerializeField]
		private int _QuestBonusReceiveType;

		[SerializeField]
		private QuestResetIntervalType _QuestBonusType;

		[SerializeField]
		private int _QuestBonusCount;

		[SerializeField]
		private int _QuestBonusStackCountMax;

		[SerializeField]
		private string _ReleaseText;

		[SerializeField]
		private string _ReleaseTextDetail;

		public int Id => default(int);

		public string EventViewName => null;

		public int ShowCatetory => default(int);

		public int UpsideCategory => default(int);

		public int SortKey => default(int);

		public QuestEventType QuestEventType => default(QuestEventType);

		public int QuestRibbonImageNo => default(int);

		public int IsViewSoloMultiTab => default(int);

		public int IsHeaderQuest => default(int);

		public int InformationId => default(int);

		public int IsViewNewBadge => default(int);

		public int QuestBonusReceiveType => default(int);

		public QuestResetIntervalType QuestBonusType => default(QuestResetIntervalType);

		public int QuestBonusCount => default(int);

		public int QuestBonusStackCountMax => default(int);

		public string ReleaseText => null;

		public string ReleaseTextDetail => null;
	}
}
