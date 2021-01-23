/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class EventZoneManager
	{
		// Fields
		private static EventZoneManager instance;
		public const float overZone = 770f;
		public List<EventZone> eZoneList;
	
		// Properties
		public static EventZoneManager Instance { get; }
	
		// Nested types
		[Flags]
		public enum Type
		{
			None = 0,
			BulletFadeOut = 1,
			EnemyDamange = 2,
			PlayerDamage = 4,
			BulletItemize = 8
		}
	
		public enum CollisionType
		{
			None = 0,
			Circle = 1,
			Square = 2
		}
	
		public class EventZone
		{
			// Fields
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
	
			// Constructors
			public EventZone();
	
			// Methods
			public bool Action();
			public bool IsInRect(float aimx, float aimy, float aimr, float oriw = 0f, float orih = 0f, int nextStep = 0);
		}
	
		// Constructors
		private EventZoneManager();
		static EventZoneManager();
	
		// Methods
		public static void Dispose();
		public void Clear();
		public void Build(Type type, CollisionType collisionType, float x, float y, int maxTime = 1, float rx = 770f, float ry = 770f, float power = 0f, float rSpeed = 0f, int initTime = 0);
		public void Action();
	}
}
