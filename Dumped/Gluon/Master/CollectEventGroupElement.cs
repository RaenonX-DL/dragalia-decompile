using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CollectEventGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _StoryGroupType;

		[SerializeField]
		private string _StoryGroupName;

		[SerializeField]
		private string _StoryBannerImage;

		public int Id => default(int);

		public int StoryGroupType => default(int);

		public string StoryGroupName => null;

		public string StoryBannerImage => null;
	}
}
