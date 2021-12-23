using System.Collections.Generic;
using Gluon.Dungeon;
using UnityEngine;

namespace Gluon
{
	public static class CollisionChecker
	{
		private static HashSet<CharacterBase> _hitCharas;

		private static List<CharacterBase> _listForgetHit;

		private static Dictionary<CharacterBase, float> hitCharasCollisionDistance;

		private static HashSet<DungeonObjectBase> _hitObjs;

		private static int _shareCount;

		private static CollisionCheckMath.Cylinder _targetCylinder;

		public static float collisionRatio;

		private static float spAdditionalRecoveryRate;

		public static HashSet<CharacterBase> hitCharas => null;

		public static bool CheckCollision(CollisionHitAttribute data, bool useAccurateCollisionHitAttribute = false)
		{
			return default(bool);
		}

		public static bool CheckCollisionWithoutExec(CollisionHitAttribute data, ref HitException exception)
		{
			return default(bool);
		}

		public static bool CheckCollision(CollisionHitAttribute data, ref HitException exception)
		{
			return default(bool);
		}

		public static bool IsUseNewHealSync(CharacterBase target, CharacterBase owner)
		{
			return default(bool);
		}

		public static void RemoveHitChara(List<CharacterBase> charaList, bool asOriginal)
		{
		}

		public static bool IsLocalHealSync(CharacterBase target, CharacterBase owner)
		{
			return default(bool);
		}

		private static bool IsCollided(CollisionHitAttribute data, ref HitException exception)
		{
			return default(bool);
		}

		private static bool CollideWithEnemy(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas)
		{
			return default(bool);
		}

		private static bool CollideWithPlayer(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas)
		{
			return default(bool);
		}

		private static bool CollideWithPlayerCommon(CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas)
		{
			return default(bool);
		}

		private static bool CollideWithPlayerCommon_Internal(CharacterBase character, CollisionHitAttribute data, ref HitException exception, HashSet<CharacterBase> hitCharas, ref CharacterBase hpLowestChara)
		{
			return default(bool);
		}

		private static bool CheckCollisionWithCharacter(CharacterBase character, CollisionHitAttribute data, ref HitException exception)
		{
			return default(bool);
		}

		private static bool IsCollideCharacter(CharacterBase character, CollisionHitAttribute data, ref HitException exception)
		{
			return default(bool);
		}

		private static bool IsCollideOtherPlayerCharacter(CharacterBase character, CollisionHitAttribute data)
		{
			return default(bool);
		}

		private static bool CollideWithPlayerBullet(CollisionHitAttribute data)
		{
			return default(bool);
		}

		public static void ExecHit(CollisionHitAttribute data)
		{
		}

		private static void ExecutionCharacterHit(CharacterBase character, CollisionHitAttribute data, int shareNum = 1)
		{
		}

		private static bool CollideWithDungeonObjects(CollisionHitAttribute data, ref HitException exception, HashSet<DungeonObjectBase> hitObjs)
		{
			return default(bool);
		}

		private static bool _CheckCollisionWithDungeonObjects(List<DungeonObjectBase> objects, CollisionHitAttribute data, ref HitException exception, HashSet<DungeonObjectBase> hitObjs)
		{
			return default(bool);
		}

		private static void GetTargetCollide(CharacterBase target)
		{
		}

		public static bool IsCollidedWithCharacterCylinder(CollisionHitAttribute data, CharacterBase target)
		{
			return default(bool);
		}

		private static bool IsInnerSafetyZone(CollisionHitAttribute data, CollisionCheckMath.Cylinder targetCylinder)
		{
			return default(bool);
		}

		private static bool IsCollided(EnemyManage.SafetyZone data, CollisionCheckMath.Cylinder targetCylinder)
		{
			return default(bool);
		}

		public static bool IsCollided(CollisionHitAttribute data, CollisionCheckMath.Cylinder targetCylinder)
		{
			return default(bool);
		}

		private static bool PointInUnRegularBounds(Vector3 pos, Bounds bounds, Vector3 boundsForward, int num)
		{
			return default(bool);
		}

		public static bool PointInUnRegularCube(Vector3 targetPos, float targetRadius, Vector3 startPos, Vector3 forward, float width, float height, float length, int num)
		{
			return default(bool);
		}

		private static bool CylinderInUnRegularCube(CollisionCheckMath.Cylinder cylinder, Vector3 startPos, Vector3 forward, float width, float height, float length, int num)
		{
			return default(bool);
		}

		private static bool CylinderInUnRegularCube02(CollisionCheckMath.Cylinder cylinder, Vector3 startPos, Vector3 forward, float width, float height, float length, int num)
		{
			return default(bool);
		}

		private static bool CylinderInNoRotatedBox(CollisionCheckMath.Cylinder cylinder, Vector3 centerPos, float width, float height, float length)
		{
			return default(bool);
		}

		private static bool IsHealCollision(CharacterBase src, CollisionHitAttribute hitAttr)
		{
			return default(bool);
		}

		private static bool IsSingleHitCollision(ActionCollision collision)
		{
			return default(bool);
		}

		private static bool CheckHitCondition(CollisionHitAttribute data, CharacterBase target)
		{
			return default(bool);
		}

		private static bool CheckHitEnemyCondition(CollisionHitAttribute data, EnemyCharacter target)
		{
			return default(bool);
		}
	}
}
