/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class SummonGetOddsDataResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public OddsRateList odds_rate_list;
			public SummonPrizeOddsRateList summon_prize_odds_rate_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public SummonGetOddsDataResponse();
	}
}
