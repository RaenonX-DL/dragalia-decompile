/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class EventD00562 : EventBase<EventD00562>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		[Required]
		public CharacterId clawEnemy;
		[Key]
		public int actionId;
		[Key]
		public short actionPartsIndex;
		[Key]
		public Vector3 position;
	
		// Constructors
		public EventD00562();
	}
}
