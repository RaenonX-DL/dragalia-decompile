/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class FortLevelupEndResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public int result;
			public ulong build_id;
			public FortDetail fort_detail;
			public FortBonusList fort_bonus_list;
			public int current_fort_level;
			public int current_fort_craft_level;
			public AtgenProductionRp production_rp;
			public AtgenProductionRp production_df;
			public AtgenProductionRp production_st;
			public UpdateDataList update_data_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public FortLevelupEndResponse();
	}
}
