using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class UnitStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _StoryReleaseType;

		[SerializeField]
		private int _ReleaseTriggerId;

		[SerializeField]
		private int _ReleaseStep;

		[SerializeField]
		private int _UnlockQuestStoryId;

		[SerializeField]
		private int _UnlockTriggerStoryId;

		[SerializeField]
		private int _SortId;

		public int Id => default(int);

		public string Title => null;

		public int GroupId => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int StoryReleaseType => default(int);

		public int ReleaseTriggerId => default(int);

		public int ReleaseStep => default(int);

		public int UnlockQuestStoryId => default(int);

		public int UnlockTriggerStoryId => default(int);

		public int SortId => default(int);
	}
}
