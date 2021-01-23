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
	public class BRGetItemEvent : EventBase<BRGetItemEvent>
	{
		// Fields
		[Key]
		public BRItemId target;
		[Key]
		public CharacterId getter;
	
		// Constructors
		public BRGetItemEvent();
	}
}
