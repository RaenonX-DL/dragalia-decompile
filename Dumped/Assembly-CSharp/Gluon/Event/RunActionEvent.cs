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
	public struct RunActionEvent
	{
		// Fields
		[Key]
		public int actionId;
		[Key]
		public RunActionParameterBase param;
	
		// Methods
		public bool IsEmpty();
		public void Clear();
	}
}
