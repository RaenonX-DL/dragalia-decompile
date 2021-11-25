using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;

namespace Gluon
{
	public struct MatchingContext
	{
		public int QuestId
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

		public bool IsBR
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

		public bool IsBRTutorial
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

		public DebugAutoJoinRoomSetting DebugAutoJoinRoomSetting
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

		public DebugMatchingSetting DebugMatchingSetting
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

		public bool IsSoloPlayWithPhoton
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

		public RandomMatchingTypes RandomMatchingType
		{
			[CompilerGenerated]
			get
			{
				return default(RandomMatchingTypes);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int MaxPlayers => default(int);

		public MatchingContext(int questId, bool isBR = false, bool isBRTutorial = false, [Optional] DebugAutoJoinRoomSetting brDebugSetting, bool isSoloPlayWithPhoton = false, RandomMatchingTypes randomMatchingType = RandomMatchingTypes.None, [Optional] DebugMatchingSetting debugMatchingSetting)
		{
		}
	}
}
