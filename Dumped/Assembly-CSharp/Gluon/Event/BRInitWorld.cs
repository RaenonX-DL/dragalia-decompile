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
	public class BRInitWorld : EventBase<BRInitWorld>
	{
		// Fields
		[Key]
		public Vector3 pulseCenterPoint;
		[Key]
		public List<BRInitWorldItemData> items;
		[Key]
		public float pulseMaxRadius;
	
		// Constructors
		public BRInitWorld();
	}
}
