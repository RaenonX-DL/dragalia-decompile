using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeStoryElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _BodyText;

		[SerializeField]
		private int _StoryReleaseFloorNum;

		[SerializeField]
		private int _StoryReleaseCharaCount;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public string Title => null;

		public string BodyText => null;

		public int StoryReleaseFloorNum => default(int);

		public int StoryReleaseCharaCount => default(int);

		public int SortId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
