namespace Gluon
{
	public class GrowthSecondManaCircleModel : GrowthManaCircleModel
	{
		public static bool isFirstEnter;

		private static GrowthAwakeResultPop.BeforeData beforeUsePlatinumCrystalData;

		public const int firstManacircleMaxPieceCount = 50;

		public const int secondManacircleMaxPieceCount = 70;

		protected override void Awake()
		{
		}

		public static bool IsReleaseSecondManaCircle(ulong charaId)
		{
			return default(bool);
		}

		public override void ReleaseManaPiece(int indexInCircle)
		{
		}

		public int GetReleasePieceIndex()
		{
			return default(int);
		}

		public override bool IsAllPointReleased()
		{
			return default(bool);
		}

		public static int GetMaxSecondManacircleCount()
		{
			return default(int);
		}

		public static void ReserveUsePlatinumCrystalDirection(GrowthAwakeResultPop.BeforeData beforeData)
		{
		}

		public static GrowthAwakeResultPop.BeforeData PopUsePlatinumCrystalDirectionReservation()
		{
			return null;
		}
	}
}
