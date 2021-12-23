using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeQuestFloorElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _FloorNum;

		[SerializeField]
		private DungeonType _DungeonType;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		[SerializeField]
		private int _BaseEnemyLevel;

		[SerializeField]
		private int _BaseBossEnemyLevel;

		[SerializeField]
		private int _DrawDungeonThemeId1;

		[SerializeField]
		private int _DrawDungeonThemeId2;

		[SerializeField]
		private int _DrawDungeonThemeId3;

		[SerializeField]
		private int _DrawDungeonThemeId4;

		[SerializeField]
		private int _DrawDungeonThemeId5;

		[SerializeField]
		private int _SkipClearFloorNum;

		public int Id => default(int);

		public int FloorNum => default(int);

		public DungeonType DungeonType => default(DungeonType);

		public string ViewStartDate => null;

		public string ViewEndDate => null;

		public int BaseEnemyLevel => default(int);

		public int BaseBossEnemyLevel => default(int);

		public int DrawDungeonThemeId1 => default(int);

		public int DrawDungeonThemeId2 => default(int);

		public int DrawDungeonThemeId3 => default(int);

		public int DrawDungeonThemeId4 => default(int);

		public int DrawDungeonThemeId5 => default(int);

		public int SkipClearFloorNum => default(int);
	}
}
