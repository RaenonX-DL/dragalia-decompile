using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Gluon.Event;

namespace Gluon
{
	public class MatchingRoomProperties
	{
		private string _region;

		private string _clusterName;

		private string _language;

		private RoomEntryCondition _condition;

		private Location _location;

		public int QuestId
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

		public MatchingType MatchingType
		{
			[CompilerGenerated]
			get
			{
				return default(MatchingType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public RoomType RoomType
		{
			[CompilerGenerated]
			get
			{
				return default(RoomType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public MatchingContext MatchingContext
		{
			[CompilerGenerated]
			get
			{
				return default(MatchingContext);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Region
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ClusterName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Language
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RoomEntryCondition RoomEntryCondition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Location Location
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Hashtable GetCustomRoomProperties()
		{
			return null;
		}

		public string[] GetCustomRoomPropertiesForLobby()
		{
			return null;
		}

		public static bool IsAutoJoinEnabled(MatchingType matchingType, RoomEntryCondition condition, RandomMatchingTypes randomMatchingType)
		{
			return default(bool);
		}
	}
}
