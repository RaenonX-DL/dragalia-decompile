using System.Runtime.CompilerServices;

namespace Gluon
{
	public class FortMapData
	{
		public static int GRID_LENGTH_X;

		public static int GRID_LENGTH_Z;

		public static int MAPCELL_ROAD_BASE;

		public MapCell[,] mapData
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

		public FortMapData(FortModel model)
		{
		}

		private void LoadMapData(FortModel model)
		{
		}

		public bool CanMoveTo(int x, int z)
		{
			return default(bool);
		}

		public MapCell? GetMapCellFromIndex(int gridIndexX, int gridIndexZ)
		{
			return null;
		}

		public void SetMapDataPutted(bool isPutted, int gridPosX, int gridPosY, int cursorSize)
		{
		}
	}
}
