/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class CallMinionEvent : EventBase<CallMinionEvent>
	{
		// Fields
		[Key]
		public int taskId;
		[Key]
		[Required]
		public CharacterId caller;
		[Key]
		[Required]
		public string label;
		[Key]
		public int baseType;
		[Key]
		public Vector3 position;
		[Key]
		public bool editDirection;
		[Key]
		public Quaternion rotation;
		[Key]
		public float areaRadius;
		[Key]
		public uint randomSeed;
	
		// Constructors
		public CallMinionEvent();
	}
}
