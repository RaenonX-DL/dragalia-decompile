/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RecoveryHpRequest : EventBase<RecoveryHpRequest>
	{
		// Fields
		[Key]
		public CharacterId character;
		[Key]
		public CharacterId from;
		[Key]
		public int healValue;
		[Key]
		public byte characterType;
		[Key]
		public short elementIndex;
		[Key]
		public int actionId;
		[Key]
		public int productId;
		[Key]
		public int bulletId;
		[Key]
		public int skillId;
		[Key]
		public int followerAvoid;
	
		// Constructors
		public RecoveryHpRequest();
	}
}
