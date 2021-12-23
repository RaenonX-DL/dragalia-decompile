using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeServitorDungeonLevelElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _DmodeLevelGroupId;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private int _Hp;

		[SerializeField]
		private int _Atk;

		public int Id => default(int);

		public int DmodeLevelGroupId => default(int);

		public int Level => default(int);

		public int Hp => default(int);

		public int Atk => default(int);
	}
}
