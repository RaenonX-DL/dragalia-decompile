/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
	
		// Constructors
		public CharacterId();
	
		// Methods
		public bool IsSame(CharacterId id);
	}
}
