using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class UserLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _NecessaryExp;

		[SerializeField]
		private int _TotalExp;

		[SerializeField]
		private int _StaminaSingle;

		[SerializeField]
		private int _FriendCount;

		public int Id => default(int);

		public int NecessaryExp => default(int);

		public int TotalExp => default(int);

		public int StaminaSingle => default(int);

		public int FriendCount => default(int);
	}
}
