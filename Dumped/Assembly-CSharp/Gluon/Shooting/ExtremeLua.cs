/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public static class ExtremeLua
	{
		// Fields
		private static bool shouldDisableSmall;
		private static Vector2[] firstWavePos;
		private static Vector2[] secondWavePos;
		private static Vector2[] thirdWavePos;
		private static Vector2[] fourthWavePos;
		private static Vector2[] upWavePos;
		private static Vector2[] WavePos5;
		private static Vector2[] WavePos6;
		private static Vector2[] WavePos7;
		private static Vector2[] WavePos8;
		private static Vector2[] WavePos11;
		private static Vector2[] WavePos12;
		private static Vector2[] WavePos13;
		private static Vector2[] WavePos20;
		private static Vector2[] WavePos21;
		private static Vector2[] WavePos23;
	
		// Constructors
		static ExtremeLua();
	
		// Methods
		private static int AMAP(BaseObject bobj);
		private static int SaveAsAMAP(Enemy enemy, int angle);
		private static int LoadAMAP(Enemy enemy);
		private static Vector2 SaveAsP(Enemy enemy, float x, float y);
		private static Vector2 LoadP(Enemy enemy);
		private static void ENChasePlayer(Enemy enemy, int chaseTime, float friction, int exitAngle, float exitSpeed);
		private static void ENChaseAim(Enemy enemy, float x, float y, int chaseTime, int exitTime, int exitAngle, float exitSpeed);
		private static void ENACTurnAngle(Enemy enemy, int beginTime, int endTime, int addAngle, float friction);
		private static void ENACDirectSet(Enemy enemy, float x, float y, int angle, float speed);
		private static Enemy BuildEnemy(float x, float y, int angle, float speed, int level, EnemyManager.TemplateType type, int infiTimer);
		private static void BuildCircle(int num, int baseAngle, float baseR, float x, float y, float speed, BulletManager.TemplateType type, int fadeInTime, int avoid);
		private static void BuildFan(int num, float x, float y, int baseAngle, int angleSpace, float speed, BulletManager.TemplateType type, int fadeInTime, int avoid);
		private static int BuildBullet(float x, float y, int angle, float speed, BulletManager.TemplateType type, int fadeInTime, int avoid);
		private static Vector2[] GenEnemyPosROLL(int count, float rangeMin, float rangeMax, float space, int tOffset, int additional = 0);
		public static void OnUpdate(int timer);
		private static void BuildCatmull(int timer, int beginTime, int duration, Vector2[] posList, int level, EnemyManager.TemplateType type, int infiTimer, EnemyManager.CatmullType catmull, bool invertX);
		private static void BuildChaseAimWave(int timer, int beginTime, int duration, Vector2[] posList, int angle, float speed, int level, EnemyManager.TemplateType type, int infiTimer, float aimxOffset, float aimyOffset, int chaseTime, int exitAngle, float exitSpeed);
		private static void BuildStraightWave(int timer, int beginTime, int duration, Vector2[] posList, int angle, float speed, int level, EnemyManager.TemplateType type, int infiTimer);
		private static void BuildTurnAngleWave(int timer, int beginTime, int duration, Vector2[] posList, int angle, float speed, int level, EnemyManager.TemplateType type, int infiTimer, int turnBeginTime, int turnEndTime, int addAngle, float friction);
		private static void BuildChasePWave(int timer, int beginTime, int duration, Vector2[] posList, int angle, float speed, int level, EnemyManager.TemplateType type, int infiTimer, int chaseTime, float friction, int exitAngle, float exitSpeed);
		private static void OnMU1Update(int timer, Enemy enemy);
		private static void OnMU2Update(int timer, Enemy enemy);
		private static void OnMU3Update(int timer, Enemy enemy);
		private static void OnMU4Update(int timer, Enemy enemy);
		private static void OnFY1Update(int timer, Enemy enemy);
		private static void OnFY2Update(int timer, Enemy enemy);
		private static void OnFY3Update(int timer, Enemy enemy);
		private static void OnFY4Update(int timer, Enemy enemy);
		private static void OnEA1Update(int timer, Enemy enemy);
		private static void OnEA2Update(int timer, Enemy enemy);
		private static void OnEA2GhostUpdate(int timer, Enemy enemy);
		private static void OnEA3Update(int timer, Enemy enemy);
		private static void OnEA4Update(int timer, Enemy enemy);
		private static void OnGFUpdate(int timer, Enemy enemy);
		private static void OnHDUpdate(int timer, Enemy enemy);
		private static void CreateWind(int mod, Enemy enemy, int count, int space);
		private static void OnMID2Update(int timer, Enemy enemy);
		private static void OnMIDUpdate(int timer, Enemy enemy);
		private static void CreateCraw(int mod, Enemy enemy);
		public static void OnEnemyUpdate(Enemy enemy, EnemyManager.TemplateType type, int level);
	}
}
