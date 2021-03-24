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
	public class AppearEnemyEvent : EventBase<AppearEnemyEvent>
	{
		// Fields
		[Key]
		public int taskId;
		[Key]
		[Required]
		public CharacterId owner;
		[Key]
		[Required]
		public CharacterId popEnemy;
		[Key]
		public CharacterId target;
		[Key]
		public Vector3 popPos;
		[Key]
		public Quaternion popRot;
		[Key]
		public int childActionid;
		[Key]
		public byte flags;
	
		// Constructors
		public AppearEnemyEvent();
	}
}
