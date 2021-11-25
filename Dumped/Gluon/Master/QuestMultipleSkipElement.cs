using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestMultipleSkipElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _QuestEventId;

		[SerializeField]
		private int _QuestEventGroupId;

		[SerializeField]
		private int _QuestId;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _LabelText;

		public int Id => default(int);

		public int QuestEventId => default(int);

		public int QuestEventGroupId => default(int);

		public int QuestId => default(int);

		public int SortId => default(int);

		public string LabelText => null;
	}
}
