using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _SectionName;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private QuestGroupType _GroupType;

		[SerializeField]
		private int _IsCutscene;

		[SerializeField]
		private int _IsViewNewStoryBadge;

		[SerializeField]
		private int _SortKey;

		[SerializeField]
		private int _AlbumStoryGroupId;

		[SerializeField]
		private int _AlbumSortId;

		[SerializeField]
		private string _ThumbnailImage;

		[SerializeField]
		private int _StoryReadCount;

		[SerializeField]
		private int _PayEntityTargetType;

		[SerializeField]
		private GiftType _PayEntityType;

		[SerializeField]
		private int _PayEntityId;

		[SerializeField]
		private int _PayEntityQuantity;

		[SerializeField]
		private int _LockViewType;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public string SectionName => null;

		public string Title => null;

		public int GroupId => default(int);

		public QuestGroupType GroupType => default(QuestGroupType);

		public int IsCutscene => default(int);

		public int IsViewNewStoryBadge => default(int);

		public int SortKey => default(int);

		public int AlbumStoryGroupId => default(int);

		public int AlbumSortId => default(int);

		public string ThumbnailImage => null;

		public int StoryReadCount => default(int);

		public int PayEntityTargetType => default(int);

		public GiftType PayEntityType => default(GiftType);

		public int PayEntityId => default(int);

		public int PayEntityQuantity => default(int);

		public int LockViewType => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
