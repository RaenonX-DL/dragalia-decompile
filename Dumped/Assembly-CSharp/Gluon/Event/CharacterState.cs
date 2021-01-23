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
	public class CharacterState : EventBase<CharacterState>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId characterId;
		[Key]
		public Vector3 position;
		[Key]
		public float rotation;
		[Key]
		public CharacterId targetId;
		[Key]
		public short index;
		[Key]
		public byte state;
		[Key]
		[Required]
		public int[] param;
		[Key]
		[Required]
		public float[] paramf;
		[Key]
		public bool isAwake;
		[Key]
		public byte[] aiScriptContext;
		[Key]
		public RunActionEvent runActionEvent;
	
		// Constructors
		public CharacterState();
	}
}
