/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public static class NormalLua
	{
		// Fields
		private static float boss1Bx;
		private static float boss1By;
	
		// Constructors
		static NormalLua();
	
		// Methods
		private static void Create1A(int t, Enemy en, int timer, int level);
		private static void BossAction1A(Enemy en, int timer, int level);
		private static void Create1B(int[,] timeTable, Enemy en, int timer, int level);
		private static void BossAction1B(Enemy en, int timer, int level);
		private static void BossAction2A(Enemy en, int timer, int level);
		private static void BossAction2B(Enemy en, int timer, int level);
		private static void BossAction2C(Enemy en, int timer, int level, bool isLeft);
		private static void BossAction2CL(Enemy en, int timer, int level);
		private static void BossAction2CR(Enemy en, int timer, int level);
		private static void BossAction2D(Enemy en, int timer, int level);
		public static void OnEnemyUpdate(Enemy en, EnemyManager.TemplateType type, int level);
		public static void OnUpdate(int time);
	}
}
