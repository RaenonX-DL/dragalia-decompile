using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class UtpCtrl
	{
		private float _point;

		private int _requirePoint;

		private UtpMultiPlayService _multiPlayService;

		public static readonly int flashingPoint;

		public float point
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		public int maxPoint
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

		public float ratio => default(float);

		public float consumePoint
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

		public int requirePoint
		{
			get
			{
				return default(int);
			}
			private set
			{
			}
		}

		public float maxRecastTime
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

		public float currRecastTime
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

		public float selfDamageRatio
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

		public bool isPauseConsume
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

		public bool isServantTransform
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

		public void Initialize(AbilityDataElement ade, int idx, bool isServantTransform, UtpMultiPlayService multiPlayService)
		{
		}

		public void Update(PlayerCharacter owner)
		{
		}

		public void AddPoint(int value, CharacterBase owner)
		{
		}

		public void AddPointForSelfDamageAbility(float rate, CharacterBase owner)
		{
		}

		public void SetPoint(float value, bool isSielent = false)
		{
		}

		public void SetIsPauseConsume(bool isPause)
		{
		}

		public bool IsEnableTransform()
		{
			return default(bool);
		}

		public bool IsFull()
		{
			return default(bool);
		}

		public void Continue()
		{
		}

		public void SetRecastTime()
		{
		}

		public static bool IsInstantUniqueTransform(PlayerCharacter owner)
		{
			return default(bool);
		}
	}
}
