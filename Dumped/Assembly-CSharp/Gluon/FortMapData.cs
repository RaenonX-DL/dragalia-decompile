/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortMapData
	{
		// Fields
		public static int GRID_LENGTH_X;
		public static int GRID_LENGTH_Z;
		public static int MAPCELL_ROAD_BASE;
		[CompilerGenerated]
		private MapCell[,] _mapData_k__BackingField;
	
		// Properties
		public MapCell[,] mapData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FortMapData(FortModel model);
		static FortMapData();
	
		// Methods
		private void LoadMapData(FortModel model);
		public bool CanMoveTo(int x, int z);
		public MapCell? GetMapCellFromIndex(int gridIndexX, int gridIndexZ);
		public void SetMapDataPutted(bool isPutted, int gridPosX, int gridPosY, int cursorSize);
	}
}
