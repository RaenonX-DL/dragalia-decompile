using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestOverwriteParamElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _OverwriteHp;

		[SerializeField]
		private int _OverwriteAtk;

		public int Id => default(int);

		public int OverwriteHp => default(int);

		public int OverwriteAtk => default(int);
	}
}
