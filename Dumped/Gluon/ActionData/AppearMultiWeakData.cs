using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class AppearMultiWeakData : ActionParts.PartsData
	{
		public enum PopType
		{
			Owner,
			WorldCenter,
			Target,
			AreaAnchor,
			TargetGround
		}

		[SerializeField]
		[HideInInspector]
		private CtrlMultiWeak.WeakType _weakType;

		[SerializeField]
		[HideInInspector]
		private int _appearanceNum;

		[SerializeField]
		[HideInInspector]
		private int _defeatedActionId;

		[SerializeField]
		[HideInInspector]
		private bool _showTimerUi;

		[SerializeField]
		[HideInInspector]
		private bool _isTimerAction;

		[SerializeField]
		[HideInInspector]
		private int _timerActionId;

		[SerializeField]
		[HideInInspector]
		private bool _waitTimerActionAfterExtra;

		[SerializeField]
		[HideInInspector]
		private bool _waitDefeatedActionAfterExtra;

		[SerializeField]
		[HideInInspector]
		private bool _waitDefeatedActionOnTimer;

		[SerializeField]
		[HideInInspector]
		private bool _isPlayActionOnShapeShit;

		[SerializeField]
		[HideInInspector]
		private CtrlMultiWeak.Mode _mode;

		[SerializeField]
		[HideInInspector]
		private float _intervalTime;

		[SerializeField]
		[HideInInspector]
		private PopType _popType;

		[SerializeField]
		[HideInInspector]
		private Vector3[] _popOffsetPos;

		[SerializeField]
		[HideInInspector]
		private float _uiTimer;

		[SerializeField]
		[HideInInspector]
		private float _effScale;

		[SerializeField]
		[HideInInspector]
		private bool _isCalcPopPositionRemotely;

		[SerializeField]
		[HideInInspector]
		private bool _enabledForEA;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private string _appearSeName;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public CtrlMultiWeak.WeakType weakType => default(CtrlMultiWeak.WeakType);

		public int appearanceNum => default(int);

		public int defeatedActionId => default(int);

		public bool showTimerUi => default(bool);

		public bool isTimerAction => default(bool);

		public int timerActionId => default(int);

		public bool waitTimerActionAfterExtra => default(bool);

		public bool waitDefeatedActionAfterExtra => default(bool);

		public bool waitDefeatedActionOnTimer => default(bool);

		public bool isPlayActionOnShapeShit => default(bool);

		public CtrlMultiWeak.Mode mode => default(CtrlMultiWeak.Mode);

		public float intervalTime => default(float);

		public PopType popType => default(PopType);

		public Vector3[] popOffsetPos => null;

		public float uiTimer => default(float);

		public float effScale => default(float);

		public bool isCalcPopPositionRemotely => default(bool);

		public bool enabledForEA => default(bool);

		public string effectName => null;

		public bool isSeparatelyLoadEffect => default(bool);

		public string appearSeName => null;

		public bool guarantee => default(bool);
	}
}
