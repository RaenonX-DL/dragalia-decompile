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
	public class BarrieredHit : EventBase<BarrieredHit>
	{
		// Fields
		[Key]
		public CharacterId targetEnemy;
		[Key]
		public int from;
		[ActionId]
		[Key]
		public int actionId;
		[Key]
		public Vector3 hitPos;
		[Key]
		public bool isFromAdditionalAttack;
	
		// Constructors
		public BarrieredHit();
	}
}
