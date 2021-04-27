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
	public class MultiWeakEvent : EventBase<MultiWeakEvent>
	{
		// Fields
		[Key]
		public MultiWeakEventTypes type;
		[Key]
		public CharacterId character;
		[Key]
		public byte mode;
		[Key]
		public byte weakType;
		[Key]
		public byte appearanceNum;
		[Key]
		public int actionId;
		[Key]
		public float intervalTime;
		[Key]
		public float uiTimer;
		[Key]
		public int timerActionId;
		[Key]
		public List<Vector3> popPositionList;
		[Key]
		public bool waitDefeatedActionOnTimer;
		[Key]
		public bool showTimerUi;
		[Key]
		public bool isPlayActionOnShapeShit;
		[Key]
		public float effScale;
		[Key]
		public bool isCalcPopPositionRemotely;
		[Key]
		public bool waitDefeatedActionAfterExtra;
		[Key]
		public bool waitTimerActionAfterExtra;
	
		// Nested types
		public enum MultiWeakEventTypes
		{
			StartWeakPoint = 0,
			AllWeakPontDefeated = 1,
			TimerAction = 2,
			NextWeakPoint = 3,
			ClearWeakPoint = 4
		}
	
		// Constructors
		public MultiWeakEvent();
	}
}
