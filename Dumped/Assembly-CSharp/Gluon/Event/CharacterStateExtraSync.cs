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
	public class CharacterStateExtraSync : EventBase<CharacterStateExtraSync>
	{
		// Fields
		[Key]
		public CharacterId character;
		[Key]
		public byte state;
		[Key]
		public CharacterStateExtraSyncBody body;
	
		// Constructors
		public CharacterStateExtraSync();
	}
}
