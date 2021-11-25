using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class ContactModel
	{
		private static ContactModel instance;

		public const int reliabilityMaxLevel = 30;

		public int selectedDragonMasterId;

		public bool isInit;

		public int pettingDragonMasterId;

		public static ContactModel Instance => null;

		public static void DeleteInstance()
		{
		}

		private ContactModel()
		{
		}

		static ContactModel()
		{
		}

		public static List<int> GetAvailablePettingList()
		{
			return null;
		}

		public static List<DragonReliabilityList> GetAvailableReliabilityList()
		{
			return null;
		}

		public static List<int> GetRecentPettedDragonList(int maxCount = 5)
		{
			return null;
		}

		public static int GetRatestPettedDragonID()
		{
			return default(int);
		}

		public List<ulong> GetAllDragonByTypeKeyIdList()
		{
			return null;
		}

		public static int GetDragonReliabilityLevel(int dragonId)
		{
			return default(int);
		}

		public static int GetDragonReliabilityTotalExp(int dragonId)
		{
			return default(int);
		}

		public int GetDragonReliabilityLevel()
		{
			return default(int);
		}

		public int GetDragonReliabilityTotalExp()
		{
			return default(int);
		}

		public bool IsWalkerUnit()
		{
			return default(bool);
		}

		public static bool IsHideDragon(int dragonId)
		{
			return default(bool);
		}
	}
}
