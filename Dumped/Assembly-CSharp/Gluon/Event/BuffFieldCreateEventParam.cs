/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BuffFieldCreateEventParam : BuffFieldEventParamBase
	{
		// Fields
		[Key]
		[Required]
		public long actionPartsResourceId;
		[Key]
		[Required]
		public uint hitAttrLabelCrc32;
		[Key]
		[Required]
		public Vector3 position;
		[Key]
		[Required]
		public Quaternion rotation;
		[Key]
		[Required]
		public int actionId;
		[Key]
		[Required]
		public int skillId;
		[Key]
		[Required]
		public int actionProductId;
		[Key]
		[Required]
		public float skillDamageUpBuffRate;
		[Key]
		[Required]
		public int warpRoomGroupId;
		[Key]
		[Required]
		public bool isHostRequest;
		[Key]
		public int tensionLevel;
		[Key]
		public int inspirationLevel;
	
		// Constructors
		public BuffFieldCreateEventParam();
	}
}
