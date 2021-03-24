/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectRouteArranger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private float _firstDotArrangeWait;
		private Dictionary<int, List<QuestSelectRoutePoint>> routePointListList;
		private Dictionary<int, int> waitFrameDic;
		[CompilerGenerated]
		private bool _isSuccessivelyArrangeReady_k__BackingField;
		private int _notImmediately;
		public UnityAction onEndArrangingRoutePoints;
		public UnityAction onStartArrangingRoutePoints;
		public UnityAction onReadyEndArrangingRoutePoints;
		public UnityAction onReadyStartArrangingRoutePoints;
		[SerializeField]
		private int defaultWaitFrame;
		private float _firstDotArrangeHastenTime;
	
		// Properties
		public float firstDotArrangeWait { get; }
		public bool isSuccessivelyArrangeReady { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int notImmediately { get; set; }
		public float FirstDotArrangeHastenTime { set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ArrageEveryRoutePoint_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectRouteArranger __4__this;
			private TouchGuardObject _touchGuard_5__2;
			private int _count_5__3;
			private bool _lastFlag_5__4;
			private int _i_5__5;
			private int _waitFrame_5__6;
			private int _k_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ArrageEveryRoutePoint_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DelayStartActivation_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestSelectRoutePoint point;
			public bool flag;
			public int delayFrame;
			public QuestSelectRouteArranger __4__this;
			private bool _isCallBack_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayStartActivation_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _DelayStartActivation_d__29 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public QuestSelectRoutePoint point;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayStartActivation_d__29(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestSelectRouteArranger();
	
		// Methods
		private void Start();
		public void ClearPointList();
		public void AddToPointList(QuestSelectRoutePoint point, int index = 0);
		public void AddFrontToPointList(QuestSelectRoutePoint point, int index = 0);
		private void ArrangeActivateImmediatelyRoutePoints();
		public void StartArrangingRoutePoints(bool isWaitSuccessivelyArrangeReady);
		[IteratorStateMachine]
		private IEnumerator ArrageEveryRoutePoint();
		[IteratorStateMachine]
		private IEnumerator DelayStartActivation(QuestSelectRoutePoint point, int delayFrame, bool flag);
		[IteratorStateMachine]
		private IEnumerator DelayStartActivation(QuestSelectRoutePoint point, float delayTime);
		public int GetListCount();
		public void SetSpecialWaitFrame(int index, int frame);
	}
}
