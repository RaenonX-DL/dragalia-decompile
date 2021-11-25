using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MainStoryGuideElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private string _TitleText;

		[SerializeField]
		private string _DescriptionText;

		[SerializeField]
		private int _ViewOpinionType;

		[SerializeField]
		private int _OpinionValue1;

		[SerializeField]
		private int _OpinionValue2;

		[SerializeField]
		private int _OpinionValue3;

		[SerializeField]
		private int _OpinionValue4;

		[SerializeField]
		private int _OpinionValue5;

		[SerializeField]
		private int _OpinionValue6;

		[SerializeField]
		private int _OpinionValue7;

		[SerializeField]
		private int _OpinionValue8;

		[SerializeField]
		private int _MoveType;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int Priority => default(int);

		public string TitleText => null;

		public string DescriptionText => null;

		public int ViewOpinionType => default(int);

		public int OpinionValue1 => default(int);

		public int OpinionValue2 => default(int);

		public int OpinionValue3 => default(int);

		public int OpinionValue4 => default(int);

		public int OpinionValue5 => default(int);

		public int OpinionValue6 => default(int);

		public int OpinionValue7 => default(int);

		public int OpinionValue8 => default(int);

		public int MoveType => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
