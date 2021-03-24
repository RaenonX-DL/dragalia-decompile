/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RecoverySpRequest : EventBase<RecoverySpRequest>
	{
		// Fields
		[Key]
		public CharacterId character;
		[Key]
		public float healRatio;
		[Key]
		public int healSkillIndex;
		[Key]
		public bool isHumanOnly;
		[Key]
		public int healValue;
	
		// Constructors
		public RecoverySpRequest();
	}
}
