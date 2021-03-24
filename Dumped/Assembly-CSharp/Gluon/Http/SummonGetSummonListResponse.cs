/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class SummonGetSummonListResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public SummonList[] summon_list;
			public SummonList[] chara_ssr_summon_list;
			public SummonList[] dragon_ssr_summon_list;
			public SummonList[] campaign_summon_list;
			public SummonList[] start_dash_summon_list;
			public SummonList[] platinum_summon_list;
			public AtgenCsSummonList cs_summon_list;
			public SummonTicketList[] summon_ticket_list;
			public SummonPointList[] summon_point_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public SummonGetSummonListResponse();
	}
}
