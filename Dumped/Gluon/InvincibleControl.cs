using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class InvincibleControl
	{
		public enum Type
		{
			None,
			Skill,
			SkillLink,
			DragonTransform,
			DragonRelease,
			Blast,
			BlastRecovery,
			Down,
			DownRecovery,
			Revive,
			EnemyPop,
			FromAction,
			FromActionCommand,
			Torpedo,
			Carried,
			InSafeArea,
			NoReceive,
			System,
			GuardCounter,
			Buff,
			EnemyGimmick,
			DungeonWarp,
			Bind,
			AlloutAssault,
			LastBossDeadAreaChange
		}

		public struct InvincibleParam
		{
			public Type type;

			public int level;

			public float sec;

			public int uid;
		}

		private List<InvincibleParam> invincibles;

		public int level
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Add(Type type, int level, float sec, int uid = 0)
		{
		}

		public void Remove(Type type, int uid = 0)
		{
		}

		public void RemoveUnderLevel(int level)
		{
		}

		public void RemoveExcludeSystem()
		{
		}

		public void Clear()
		{
		}

		public void Update(float delta)
		{
		}

		private void SetLevel()
		{
		}

		public void InactivateDownRecovery()
		{
		}

		public string GetZombieLog()
		{
			return null;
		}
	}
}
