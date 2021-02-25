/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CollisionChecker
	{
		// Fields
		private static HashSet<CharacterBase> _hitCharas;
		private static List<CharacterBase> _listForgetHit;
		private static Dictionary<CharacterBase, float> hitCharasCollisionDistance;
		private static HashSet<DungeonObjectBase> _hitObjs;
		private static int _shareCount;
		private static CollisionCheckMath.Cylinder _targetCylinder;
		public static float collisionRatio;
		private static float spAdditionalRecoveryRate;
	
		// Properties
		public static HashSet<CharacterBase> hitCharas { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public List<CharacterBase> charaList;
			public bool asOriginal;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal bool _RemoveHitChara_b__0(CharacterBase x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public CollisionHitAttribute data;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal bool _IsCollided_b__0(CharacterBase character);
		}
	
		// Constructors
		static CollisionChecker();
	
		// Methods
		public static bool CheckCollision(CollisionHitAttribute data);
		public static bool CheckCollisionWithoutExec(CollisionHitAttribute data, ref HitException exception);
		public static bool CheckCollision(CollisionHitAttribute data, ref HitException exception);
		public static bool IsUseNewHealSync(CharacterBase target, CharacterBase owner);
		public static void RemoveHitChara(List<CharacterBase> charaList, bool asOriginal);
		public static bool IsLocalHealSync(CharacterBase target, CharacterBase owner);
		private static bool IsCollided(CollisionHitAttribute data, ref HitException exception);
		private static bool CollideWithEnemy(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas);
		private static bool CollideWithPlayer(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas);
		private static bool CollideWithPlayerCommon(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas);
		private static bool CollideWithPlayerCommon_Internal(CharacterBase character, CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas, ref CharacterBase hpLowestChara);
		private static bool CheckCollisionWithCharacter(CharacterBase character, CollisionHitAttribute data, ref HitException exception);
		private static bool IsCollideCharacter(CharacterBase character, CollisionHitAttribute data, ref HitException exception);
		private static bool IsCollideOtherPlayerCharacter(CharacterBase character, CollisionHitAttribute data);
		public static void ExecHit(CollisionHitAttribute data);
		private static void ExecutionCharacterHit(CharacterBase character, CollisionHitAttribute data, int shareNum = 1);
		private static bool CollideWithDungeonObjects(CollisionHitAttribute data, ref HitException exception, HashSet<DungeonObjectBase> hitObjs);
		private static bool _CheckCollisionWithDungeonObjects(List<DungeonObjectBase> objects, CollisionHitAttribute data, ref HitException exception, HashSet<DungeonObjectBase> hitObjs);
		private static void GetTargetCollide(CharacterBase target);
		private static bool IsInnerSafetyZone(CollisionHitAttribute data, CollisionCheckMath.Cylinder targetCylinder);
		private static bool IsCollided(EnemyManage.SafetyZone data, CollisionCheckMath.Cylinder targetCylinder);
		public static bool IsCollided(CollisionHitAttribute data, CollisionCheckMath.Cylinder targetCylinder);
		private static bool PointInUnRegularBounds(Vector3 pos, Bounds bounds, Vector3 boundsForward, int num);
		public static bool PointInUnRegularCube(Vector3 targetPos, float targetRadius, Vector3 startPos, Vector3 forward, float width, float height, float length, int num);
		private static bool CylinderInUnRegularCube(CollisionCheckMath.Cylinder cylinder, Vector3 startPos, Vector3 forward, float width, float height, float length, int num);
		private static bool CylinderInUnRegularCube02(CollisionCheckMath.Cylinder cylinder, Vector3 startPos, Vector3 forward, float width, float height, float length, int num);
		private static bool CylinderInNoRotatedBox(CollisionCheckMath.Cylinder cylinder, Vector3 centerPos, float width, float height, float length);
		private static bool IsHealCollision(CharacterBase src, ActionHitExecType hitExecType);
		private static bool IsSingleHitCollision(ActionCollision collision);
		private static bool CheckHitCondition(CollisionHitAttribute data);
		private static bool CheckHitEnemyCondition(CollisionHitAttribute data, EnemyCharacter target);
	}
}
