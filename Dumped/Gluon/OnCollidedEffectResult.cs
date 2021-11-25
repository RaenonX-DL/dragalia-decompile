using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(0, Size = 24)]
	public struct OnCollidedEffectResult
	{
		public bool hasDesignatedHitEffect
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public long designatedHitEffectResourceId
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool hasDesignatedHitSE
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPlayNormalHitSE
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void SetIsEffectDesignated(long resourceId = 0L)
		{
		}

		public void SetIsSEDesignated(bool isPlayNormalHitSE, long resourceId = 0L)
		{
		}

		public void Clear()
		{
		}
	}
}
