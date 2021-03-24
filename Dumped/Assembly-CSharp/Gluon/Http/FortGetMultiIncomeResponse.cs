/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class FortGetMultiIncomeResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public int result;
			public AtgenHarvestBuildList[] harvest_build_list;
			public AtgenAddCoinList[] add_coin_list;
			public AtgenAddStaminaList[] add_stamina_list;
			public int is_over_coin;
			public int is_over_material;
			public UpdateDataList update_data_list;
			public EntityResult entity_result;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public FortGetMultiIncomeResponse();
	}
}
