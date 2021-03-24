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
	public class GameStepEvent : EventBase<GameStepEvent>
	{
		// Fields
		[Key]
		public StepTypes step;
	
		// Nested types
		public enum StepTypes
		{
			None = 0,
			BRRequestInitWorld = 1,
			BRCompleteInitWorld = 2,
			JoinBeginPartySwitch = 3,
			JoinChangeCharacter = 4
		}
	
		// Constructors
		public GameStepEvent();
	}
}
