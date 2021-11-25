using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestMainGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _EventViewName;

		[SerializeField]
		private int _ChapterNum;

		[SerializeField]
		private int _WorldMapId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private float _TopBackgroundPoint;

		[SerializeField]
		private float _LeftBackgroundPoint;

		[SerializeField]
		private float _RightBackgroundPoint;

		[SerializeField]
		private float _BottomBackgroundPoint;

		[SerializeField]
		private string _SynopsisText;

		[SerializeField]
		private string _FirstHalfTrailerEndDate;

		[SerializeField]
		private string _FirstHalfTrailerTitle;

		[SerializeField]
		private string _FirstHalfTrailerText;

		[SerializeField]
		private QuestType _FirstHalfTrailerQuestType;

		[SerializeField]
		private int _FirstHalfTrailerQuestId;

		[SerializeField]
		private string _TrailerEndDate;

		[SerializeField]
		private string _TrailerTitle;

		[SerializeField]
		private string _TrailerText;

		[SerializeField]
		private QuestType _TrailerQuestType;

		[SerializeField]
		private int _TrailerQuestId;

		public int Id => default(int);

		public string EventViewName => null;

		public int ChapterNum => default(int);

		public int WorldMapId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public float TopBackgroundPoint => default(float);

		public float LeftBackgroundPoint => default(float);

		public float RightBackgroundPoint => default(float);

		public float BottomBackgroundPoint => default(float);

		public string SynopsisText => null;

		public string FirstHalfTrailerEndDate => null;

		public string FirstHalfTrailerTitle => null;

		public string FirstHalfTrailerText => null;

		public QuestType FirstHalfTrailerQuestType => default(QuestType);

		public int FirstHalfTrailerQuestId => default(int);

		public string TrailerEndDate => null;

		public string TrailerTitle => null;

		public string TrailerText => null;

		public QuestType TrailerQuestType => default(QuestType);

		public int TrailerQuestId => default(int);
	}
}
