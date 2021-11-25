using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _NecessaryExp;

		[SerializeField]
		private int _TotalExp;

		public int Id => default(int);

		public int NecessaryExp => default(int);

		public int TotalExp => default(int);
	}
}
