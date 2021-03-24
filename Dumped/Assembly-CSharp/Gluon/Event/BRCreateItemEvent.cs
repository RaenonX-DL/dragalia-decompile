/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BRCreateItemEvent : EventBase<BRCreateItemEvent>
	{
		// Fields
		[Key]
		public Vector3 pos;
		[Key]
		public float radius;
		[Key]
		public uint seed;
		[Key]
		public List<BRItemParam> items;
		[Key]
		public PatternTypes pattern;
	
		// Nested types
		public enum PatternTypes
		{
			RandomPop = 0,
			Silent = 1
		}
	
		// Constructors
		public BRCreateItemEvent();
	}
}
