/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http
{
	public class WallGetWallClearPartyResponse : ResponseCommon
	{
		// Fields
		public CommonResponse data;
	
		// Nested types
		public class CommonResponse
		{
			// Fields
			public AtgenWallClearParty wall_clear_party;
			public PartySettingList[] wall_clear_party_setting_list;
			public AtgenLostUnitList[] lost_unit_list;
	
			// Constructors
			public CommonResponse();
		}
	
		// Constructors
		public WallGetWallClearPartyResponse();
	}
}
