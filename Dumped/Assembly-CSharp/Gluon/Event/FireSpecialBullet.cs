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
	public class FireSpecialBullet : EventBase<FireSpecialBullet>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId character;
		[Key]
		public int actionProductId;
		[Key]
		public Quaternion rotation;
		[Key]
		public Vector3 aimingPoint;
	
		// Constructors
		public FireSpecialBullet();
	}
}
