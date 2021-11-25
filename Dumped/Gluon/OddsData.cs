using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Http;

namespace Gluon
{
	public class OddsData
	{
		public class ObjectDrop
		{
			public int objId;

			public int objType;

			public int isRare;

			public List<EntityData> dropList;

			public List<int> placeList;
		}

		public class EnemyDropList
		{
			public int mana;

			public int coin;

			public List<EntityData> dropList;

			public List<int> placeList;

			public bool isOddsAddCoin;

			public bool isOddsAddMana;
		}

		public class EnemyDrop
		{
			public int piece;

			public int paramId;

			public int enemyIdx;

			public bool isPop;

			public bool isRare;

			public List<EnemyDropList> enemyDropList;
		}

		public class GradeBonus
		{
			public int minValue;

			public int maxValue;

			public int gradeNum;

			public List<EntityData> dropList;
		}

		public int areaIndex;

		public Dictionary<int, ObjectDrop> objDrop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<EnemyDrop> enemyDrop
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<GradeBonus> gradeBonus
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public OddsData(OddsInfo basedata)
		{
		}

		private void Initialize(OddsInfo basedata)
		{
		}

		private EnemyDropList getEnemyDropList(int enemyIdx, int smashIdx)
		{
			return null;
		}

		public int getEnemySmashCoin(int enemyIdx, int smashIdx)
		{
			return default(int);
		}

		public int getEnemySmashMana(int enemyIdx, int smashIdx)
		{
			return default(int);
		}

		public List<EntityData> getEnemySmashDropList(int enemyIdx, int smashIdx)
		{
			return null;
		}

		public int getEnemySmashPlace(int enemyIdx, int smashIdx, int entityIdx)
		{
			return default(int);
		}

		public bool IsEnemySmashOddsAddCoin(int enemyIdx, int smashIdx)
		{
			return default(bool);
		}

		public bool IsEnemySmashOddsAddMana(int enemyIdx, int smashIdx)
		{
			return default(bool);
		}

		public int GetGradeNum(int gradePoint)
		{
			return default(int);
		}

		public int GetGradeOfPoint(int gradePoint)
		{
			return default(int);
		}

		public List<EntityData> GetGradeEntity(int gradePoint)
		{
			return null;
		}
	}
}
