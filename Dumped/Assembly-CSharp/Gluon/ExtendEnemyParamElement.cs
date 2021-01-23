/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ExtendEnemyParamElement
	{
		// Fields
		private static readonly int registAbnormalRateCount;
	
		// Nested types
		public enum EnemyParamaEnum
		{
			POISON = 1,
			BURN = 2,
			FREEZE = 3,
			PARALYSIS = 4,
			DARKNESS = 5,
			SWOON = 6,
			SLOWMOVE = 7,
			SLEEP = 8,
			CURSE = 9,
			FROSTBITE = 10,
			FLASHHEAT = 11,
			CRASHWIND = 12,
			DARKABS = 13,
			DESTROYFIRE = 14
		}
	
		// Constructors
		static ExtendEnemyParamElement();
	
		// Extension methods
		public static int GetRegistAbnormalId(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber);
		public static int GetRegistAbnormalRate(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber);
		public static AbnormalStatusType GetRegistAbnormalType(this EnemyParamElement masterData, int enemyParamAbnormalStatusNumber);
		public static int GetRegistAbnormalRateCount(this EnemyParamElement masterData);
	}
}
