using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GuideWindowElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GuideGroupId;

		[SerializeField]
		private int _GuideType;

		[SerializeField]
		private int _PageNum;

		[SerializeField]
		private string _Title;

		[SerializeField]
		private string _ImageName;

		[SerializeField]
		private string _Text;

		public int Id => default(int);

		public int GuideGroupId => default(int);

		public int GuideType => default(int);

		public int PageNum => default(int);

		public string Title => null;

		public string ImageName => null;

		public string Text => null;
	}
}
