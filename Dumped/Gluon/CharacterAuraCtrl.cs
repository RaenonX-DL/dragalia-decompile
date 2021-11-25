using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class CharacterAuraCtrl
	{
		public class Parameter
		{
			public const int defaultBaseAuraMaxLimitLevel = 2;

			public int multiPlayKey
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

			public int auraId
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

			public AuraType auraType
			{
				[CompilerGenerated]
				get
				{
					return default(AuraType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AuraConst.TargetType targetType
			{
				[CompilerGenerated]
				get
				{
					return default(AuraConst.TargetType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int level
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

			public float rate
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

			public float duration
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

			public float initialDuration
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

			public CharacterBase from
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

			public int actionId
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

			public int skillId
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

			public int productId
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

			public int publishLevel
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

			public Dictionary<int, int> maxLimitLevelDict
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

			public int maxLimitLevel
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int levelForDisplay => default(int);

			public int maxLimitLevelForDisplay => default(int);

			public bool LevelDown()
			{
				return default(bool);
			}

			public bool LevelUp(CharacterBase owner, PublishParam publishParam, int applyLimitLevel, out bool durationUpdate)
			{
				return default(bool);
			}

			public static void Publish(AuraDataElement elem, PublishParam publishParam, int maxLimitLevel)
			{
			}
		}

		public struct PublishParam
		{
			public CharacterBase from;

			public int actionId;

			public int skillId;

			public int productId;

			public void Setup(CharacterBase from, int actionId, int skillId, int productId)
			{
			}
		}

		public List<Parameter> auraList
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

		public bool isDirty
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

		public float elapsedSupportGameTime
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

		public void OnPublished(CharacterBase owner, AuraDataElement elem, PublishParam publishParam, int maxLimitLevel)
		{
		}

		public void OnApplyByHitAttribute(CharacterBase owner, CollisionHitAttribute hitAttribute)
		{
		}

		private float GetDeltaTime(CharacterBase owner)
		{
			return default(float);
		}

		public bool Update(CharacterBase owner)
		{
			return default(bool);
		}

		public void ResetDirty(CharacterBase owner)
		{
		}

		public void ResetAll(CharacterBase owner, RemoveBuffReason reason)
		{
		}

		public bool CheckValidEffect()
		{
			return default(bool);
		}

		public void Calculate(CharacterBase owner)
		{
		}

		public bool HasType(AuraType type, AuraConst.TargetType targetType)
		{
			return default(bool);
		}

		public int GetAuraLevelByType(AuraType type, AuraConst.TargetType targetType)
		{
			return default(int);
		}

		public int GetAuraLevelSum(AuraConst.TargetType targetType)
		{
			return default(int);
		}

		public Parameter FindAuraFromMultiPlayKey(int multiPlayKey)
		{
			return null;
		}

		public bool IsPublisher(CharacterBase owner, CharacterBase from)
		{
			return default(bool);
		}
	}
}
