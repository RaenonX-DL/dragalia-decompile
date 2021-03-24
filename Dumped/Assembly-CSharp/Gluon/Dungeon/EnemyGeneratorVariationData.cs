/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class EnemyGeneratorVariationData : MonoBehaviour
	{
		// Fields
		public List<EnemyGenerateLimitData> limitDataList;
	
		// Nested types
		[Serializable]
		public class EnemyGenerateLimitData
		{
			// Fields
			public int enemyId;
			public int limitCount;
	
			// Constructors
			public EnemyGenerateLimitData();
		}
	
		// Constructors
		public EnemyGeneratorVariationData();
	
		// Methods
		public Dictionary<int, int> GetEnemyGenerateLimitData();
	}
}
