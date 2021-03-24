/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class AuraEvent : EventBase<AuraEvent>
	{
		// Fields
		[Key]
		[Required]
		public List<AuraEventCommandData> commands;
	
		// Constructors
		public AuraEvent();
	}
}
