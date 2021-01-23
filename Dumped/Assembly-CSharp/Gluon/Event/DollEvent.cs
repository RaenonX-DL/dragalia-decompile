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
	public class DollEvent : EventBase<DollEvent>
	{
		// Fields
		[Key]
		public CharacterId target;
		[Key]
		public CharacterId from;
		[Key]
		public int value;
		[Key]
		public float duration;
		[Key]
		public bool isTimeUp;
	
		// Constructors
		public DollEvent();
	}
}
