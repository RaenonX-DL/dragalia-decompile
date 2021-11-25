using System;
using System.Collections.Generic;

namespace Gluon.Shooting
{
	public class EventZoneManager
	{
		[Flags]
		public enum Type
		{
			None = 0x0,
			BulletFadeOut = 0x1,
			EnemyDamange = 0x2,
			PlayerDamage = 0x4,
			BulletItemize = 0x8
		}

		public enum CollisionType
		{
			None,
			Circle,
			Square
		}

		public class EventZone
		{
			public float x;

			public float y;

			public float rx;

			public float ry;

			public float rSpeed;

			public float power;

			public float width;

			public int timer;

			public int maxTime;

			public Type type;

			public CollisionType collisionType;

			public int id;

			public bool Action()
			{
				return default(bool);
			}

			public bool IsInRect(float aimx, float aimy, float aimr, float oriw = 0f, float orih = 0f, int nextStep = 0)
			{
				return default(bool);
			}
		}

		private static EventZoneManager instance;

		public const float overZone = 770f;

		public List<EventZone> eZoneList;

		public static EventZoneManager Instance => null;

		public static void Dispose()
		{
		}

		private EventZoneManager()
		{
		}

		public void Clear()
		{
		}

		public void Build(Type type, CollisionType collisionType, float x, float y, int maxTime = 1, float rx = 770f, float ry = 770f, float power = 0f, float rSpeed = 0f, int initTime = 0)
		{
		}

		public void Action()
		{
		}
	}
}
