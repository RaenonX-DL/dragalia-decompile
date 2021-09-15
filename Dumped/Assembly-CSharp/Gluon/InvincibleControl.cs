/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InvincibleControl
	{
		// Fields
		private List<InvincibleParam> invincibles;
		[CompilerGenerated]
		private int _level_k__BackingField;
	
		// Properties
		public int level { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum Type
		{
			None = 0,
			Skill = 1,
			SkillLink = 2,
			DragonTransform = 3,
			DragonRelease = 4,
			Blast = 5,
			BlastRecovery = 6,
			Down = 7,
			DownRecovery = 8,
			Revive = 9,
			EnemyPop = 10,
			FromAction = 11,
			FromActionCommand = 12,
			Torpedo = 13,
			Carried = 14,
			InSafeArea = 15,
			NoReceive = 16,
			System = 17,
			GuardCounter = 18,
			Buff = 19,
			EnemyGimmick = 20,
			DungeonWarp = 21,
			Bind = 22,
			AlloutAssault = 23,
			LastBossDeadAreaChange = 24
		}
	
		public struct InvincibleParam
		{
			// Fields
			public Type type;
			public int level;
			public float sec;
			public int uid;
		}
	
		// Constructors
		public InvincibleControl();
	
		// Methods
		public void Add(Type type, int level, float sec, int uid = 0);
		public void Remove(Type type, int uid = 0);
		public void RemoveUnderLevel(int level);
		public void RemoveExcludeSystem();
		public void Clear();
		public void Update(float delta);
		private void SetLevel();
		public void InactivateDownRecovery();
		public string GetZombieLog();
	}
}
