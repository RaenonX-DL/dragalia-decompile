/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class OverDriveCounter : EventBase<OverDriveCounter>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId owner;
		[Key]
		[Required]
		public CharacterId target;
	
		// Constructors
		public OverDriveCounter();
	}
}
