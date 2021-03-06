﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class FortGetDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public FortDetail fort_detail;
			public BuildList[] build_list;
			public FortBonusList fort_bonus_list;
			public AtgenProductionRp production_rp;
			public AtgenProductionRp production_df;
			public AtgenProductionRp production_st;
			public int dragon_contact_free_gift_count;
			public int current_server_time;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public FortGetDataResponse();
	}
}
