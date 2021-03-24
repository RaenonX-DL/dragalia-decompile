/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class CharacterId
	{
		// Fields
		[Key]
		public short actorId;
		[Key]
		public short index;
		public const int ServantIndexOffset = 20;
		public const int LatterPartyIndexOffset = 40;
		public const int GuestPlayerIndexOffset = 100;
	
		// Constructors
		public CharacterId();
	
		// Methods
		public bool IsSame(CharacterId id);
		public static CharacterId GetPlayerCharacterId(int partySwitchIndex, int actorId, int index, bool isServant = false, bool isGuest = false);
		public override string ToString();
		public int GetPartySwitchIndex();
	}
}
