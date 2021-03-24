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
	public class Charge : EventBase<Charge>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId characterId;
		[Key]
		public float rotation;
		[Key]
		public float pullLength;
		[Key]
		public Vector3 markerPos;
	
		// Constructors
		public Charge();
	}
}
