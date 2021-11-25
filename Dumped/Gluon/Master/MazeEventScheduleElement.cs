using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MazeEventScheduleElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _TopViewState;

		[SerializeField]
		private int _MazeItemRate;

		[SerializeField]
		private int _MazePointRate;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		public int Id => default(int);

		public int TopViewState => default(int);

		public int MazeItemRate => default(int);

		public int MazePointRate => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;
	}
}
