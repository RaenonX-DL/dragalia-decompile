using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestScoreMissionDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _BaseScore1;

		[SerializeField]
		private int _BaseScore2;

		[SerializeField]
		private int _BaseScore3;

		[SerializeField]
		private int _BaseScore4;

		[SerializeField]
		private int _BaseScore5;

		[SerializeField]
		private int _BaseScore6;

		[SerializeField]
		private int _BaseScore7;

		[SerializeField]
		private int _BaseScore8;

		[SerializeField]
		private int _BaseScore9;

		[SerializeField]
		private int _BaseScore10;

		public int Id => default(int);

		public int BaseScore1 => default(int);

		public int BaseScore2 => default(int);

		public int BaseScore3 => default(int);

		public int BaseScore4 => default(int);

		public int BaseScore5 => default(int);

		public int BaseScore6 => default(int);

		public int BaseScore7 => default(int);

		public int BaseScore8 => default(int);

		public int BaseScore9 => default(int);

		public int BaseScore10 => default(int);
	}
}
