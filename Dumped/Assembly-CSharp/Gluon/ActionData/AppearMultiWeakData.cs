/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class AppearMultiWeakData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
		[HideInInspector]
		[SerializeField]
		private CtrlMultiWeak.WeakType _weakType;
		[HideInInspector]
		[SerializeField]
		private int _appearanceNum;
		[HideInInspector]
		[SerializeField]
		private int _defeatedActionId;
		[HideInInspector]
		[SerializeField]
		private bool _showTimerUi;
		[HideInInspector]
		[SerializeField]
		private bool _isTimerAction;
		[HideInInspector]
		[SerializeField]
		private int _timerActionId;
		[HideInInspector]
		[SerializeField]
		private bool _waitDefeatedActionOnTimer;
		[HideInInspector]
		[SerializeField]
		private bool _isPlayActionOnShapeShit;
		[HideInInspector]
		[SerializeField]
		private CtrlMultiWeak.Mode _mode;
		[HideInInspector]
		[SerializeField]
		private float _intervalTime;
		[HideInInspector]
		[SerializeField]
		private PopType _popType;
		[HideInInspector]
		[SerializeField]
		private Vector3[] _popOffsetPos;
		[HideInInspector]
		[SerializeField]
		private float _uiTimer;
		[HideInInspector]
		[SerializeField]
		private float _effScale;
		[HideInInspector]
		[SerializeField]
		private bool _isCalcPopPositionRemotely;
	
		// Properties
		public bool guarantee { get; }
		public CtrlMultiWeak.WeakType weakType { get; }
		public int appearanceNum { get; }
		public int defeatedActionId { get; }
		public bool showTimerUi { get; }
		public bool isTimerAction { get; }
		public int timerActionId { get; }
		public bool waitDefeatedActionOnTimer { get; }
		public bool isPlayActionOnShapeShit { get; }
		public CtrlMultiWeak.Mode mode { get; }
		public float intervalTime { get; }
		public PopType popType { get; }
		public Vector3[] popOffsetPos { get; }
		public float uiTimer { get; }
		public float effScale { get; }
		public bool isCalcPopPositionRemotely { get; }
	
		// Nested types
		public enum PopType
		{
			Owner = 0,
			WorldCenter = 1,
			Target = 2,
			AreaAnchor = 3,
			TargetGround = 4
		}
	
		// Constructors
		public AppearMultiWeakData();
	}
}
