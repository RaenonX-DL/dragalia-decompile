using System.Collections.Generic;
using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class MultiWeakEvent : EventBase<MultiWeakEvent>
	{
		public enum MultiWeakEventTypes
		{
			StartWeakPoint,
			AllWeakPontDefeated,
			TimerAction,
			NextWeakPoint,
			ClearWeakPoint,
			TurnAllWeak
		}

		[Key(1)]
		public MultiWeakEventTypes type;

		[Key(2)]
		public CharacterId character;

		[Key(3)]
		public byte mode;

		[Key(4)]
		public byte weakType;

		[Key(5)]
		public byte appearanceNum;

		[Key(6)]
		public int actionId;

		[Key(7)]
		public float intervalTime;

		[Key(8)]
		public float uiTimer;

		[Key(9)]
		public int timerActionId;

		[Key(10)]
		public List<Vector3> popPositionList;

		[Key(11)]
		public bool waitDefeatedActionOnTimer;

		[Key(12)]
		public bool showTimerUi;

		[Key(13)]
		public bool isPlayActionOnShapeShit;

		[Key(14)]
		public float effScale;

		[Key(15)]
		public bool isCalcPopPositionRemotely;

		[Key(16)]
		public bool waitDefeatedActionAfterExtra;

		[Key(17)]
		public bool waitTimerActionAfterExtra;

		[Key(18)]
		public bool enabledForEA;

		[Key(19)]
		public int axis;

		[Key(20)]
		public float offsetRotate;

		[Key(21)]
		public string effectName;
	}
}
