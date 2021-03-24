/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WallStartStartResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public IngameData ingame_data;
			public IngameWallData ingame_wall_data;
			public OddsInfo odds_info;
			public UpdateDataList update_data_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public WallStartStartResponse();
	}
}
