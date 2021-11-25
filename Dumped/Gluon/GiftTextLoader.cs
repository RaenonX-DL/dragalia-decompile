using System.Runtime.CompilerServices;

namespace Gluon
{
	public class GiftTextLoader
	{
		public class NameAndDescription
		{
			public string name
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

			public string secondName
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

			public string description
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

			public NameAndDescription()
			{
			}

			public NameAndDescription(string a_name, string a_description, string a_secondName = "")
			{
			}
		}

		public static NameAndDescription GetNameAndDescription(GiftType giftType, int itemID, long itemNum)
		{
			return null;
		}

		public static NameAndDescription GetPieceNameAndDescription(int enemyID, int enemyNum = 0)
		{
			return null;
		}

		public static string GetName(GiftType giftType, int itemID, int itemNum = 0)
		{
			return null;
		}

		public static string GetDescription(GiftType giftType, int itemID, int itemNum = 0)
		{
			return null;
		}

		public static string GetSecondName(GiftType giftType, int itemID, int itemNum = 0)
		{
			return null;
		}
	}
}
