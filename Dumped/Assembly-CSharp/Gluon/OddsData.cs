/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OddsData
	{
		// Fields
		public int areaIndex;
		[CompilerGenerated]
		private Dictionary<int, ObjectDrop> _objDrop_k__BackingField;
		[CompilerGenerated]
		private List<EnemyDrop> _enemyDrop_k__BackingField;
		[CompilerGenerated]
		private List<GradeBonus> _gradeBonus_k__BackingField;
	
		// Properties
		public Dictionary<int, ObjectDrop> objDrop { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<EnemyDrop> enemyDrop { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<GradeBonus> gradeBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class ObjectDrop
		{
			// Fields
			public int objId;
			public int objType;
			public int isRare;
			public List<EntityData> dropList;
			public List<int> placeList;
	
			// Constructors
			public ObjectDrop();
		}
	
		public class EnemyDropList
		{
			// Fields
			public int mana;
			public int coin;
			public List<EntityData> dropList;
			public List<int> placeList;
			public bool isOddsAddCoin;
			public bool isOddsAddMana;
	
			// Constructors
			public EnemyDropList();
		}
	
		public class EnemyDrop
		{
			// Fields
			public int piece;
			public int paramId;
			public int enemyIdx;
			public bool isPop;
			public bool isRare;
			public List<EnemyDropList> enemyDropList;
	
			// Constructors
			public EnemyDrop();
		}
	
		public class GradeBonus
		{
			// Fields
			public int minValue;
			public int maxValue;
			public int gradeNum;
			public List<EntityData> dropList;
	
			// Constructors
			public GradeBonus();
		}
	
		// Constructors
		public OddsData(OddsInfo basedata);
	
		// Methods
		private void Initialize(OddsInfo basedata);
		private EnemyDropList getEnemyDropList(int enemyIdx, int smashIdx);
		public int getEnemySmashCoin(int enemyIdx, int smashIdx);
		public int getEnemySmashMana(int enemyIdx, int smashIdx);
		public List<EntityData> getEnemySmashDropList(int enemyIdx, int smashIdx);
		public int getEnemySmashPlace(int enemyIdx, int smashIdx, int entityIdx);
		public bool IsEnemySmashOddsAddCoin(int enemyIdx, int smashIdx);
		public bool IsEnemySmashOddsAddMana(int enemyIdx, int smashIdx);
		public int GetGradeNum(int gradePoint);
		public int GetGradeOfPoint(int gradePoint);
		public List<EntityData> GetGradeEntity(int gradePoint);
	}
}
