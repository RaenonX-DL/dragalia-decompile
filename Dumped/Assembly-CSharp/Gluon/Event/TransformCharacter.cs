/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class TransformCharacter : EventBase<TransformCharacter>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId characterId;
		[Key]
		public bool isHuman;
		[Key]
		public bool isFinishDragon;
		[Key]
		public int dp;
	
		// Constructors
		public TransformCharacter();
	}
}
