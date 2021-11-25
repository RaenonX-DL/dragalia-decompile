using UnityEngine;

namespace Gluon
{
	public class MatchingRoomTempData : MonoBehaviour
	{
		private static MatchingRoomTempData instance;

		private MatchingService.Room _room;

		private MatchingService.Player _player;

		public MatchingService.Room room
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MatchingService.Player player
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static MatchingRoomTempData Instance => null;

		public static void Create()
		{
		}

		public static void Destroy()
		{
		}
	}
}
