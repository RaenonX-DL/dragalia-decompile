using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;

namespace Gluon
{
	public class ActionStartParameter
	{
		public class BurstDamageUpData
		{
			public float total
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float buff
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float aura
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float other
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float down
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int fireCount
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Clear()
			{
			}

			public void SetUp(float buff, float aura, float other, float down)
			{
			}

			public void SetTotalForcibly(float total)
			{
			}

			private void CalcTotal()
			{
			}
		}

		public float[] cpCoef;

		public int totalDamageOnDamageCounterMode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float skillDamageUpBuffRate
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float additionalDamageOnHpConsumption
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public WarpRoom.RoomGroup warpRoomGroupId
		{
			[CompilerGenerated]
			get
			{
				return default(WarpRoom.RoomGroup);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int hitCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int buffCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<int, int> specificBuffCounts
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int tensionLevel
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int inspirationLevel
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<int, bool> conditionCheckResults
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BurstDamageUpData burstDamageUpData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Clear()
		{
		}

		public void Clone(ActionStartParameter src)
		{
		}
	}
}
