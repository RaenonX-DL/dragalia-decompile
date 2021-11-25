using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EventTradeGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _EventId;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		[SerializeField]
		private int _TabGroupCount;

		[SerializeField]
		private string _TabGroupText1;

		[SerializeField]
		private string _TabGroupText2;

		[SerializeField]
		private string _TabGroupText3;

		[SerializeField]
		private string _TabGroupText4;

		public int Id => default(int);

		public int EventId => default(int);

		public int Priority => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;

		public int TabGroupCount => default(int);

		public string TabGroupText1 => null;

		public string TabGroupText2 => null;

		public string TabGroupText3 => null;

		public string TabGroupText4 => null;
	}
}
