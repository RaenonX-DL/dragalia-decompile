/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BackKeyManager : SingletonMonoBehaviour<Gluon.BackKeyManager>
	{
		// Fields
		protected List<int> sortingOrders;
		protected Dictionary<int, UnityEvent> eventDict;
		public int tempSortingOrder;
		public static DateTime lastTouchDownDateTime;
		public float doubleTouchThreshold;
		[CompilerGenerated]
		private bool _canCheckTutorialStatus_k__BackingField;
		protected bool isAndroid;
	
		// Properties
		public bool canCheckTutorialStatus { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public Action onBeforeExitScene;
			public float delay;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _GotoMyPageAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public Action toMyPageAction;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _GotoMyPageAction_b__2();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__17_3;
			public static Action __9__17_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _GotoMyPageAction_b__17_1();
			internal void _GotoMyPageAction_b__17_3();
		}
	
		// Constructors
		public BackKeyManager();
		static BackKeyManager();
	
		// Methods
		private void Update();
		protected override void Awake();
		public void OnPressedBackKey();
		public void AddSortingOrder(int sortingOrder);
		public int GetSortingOrderNum();
		public void SetBackKeyEvent(int sortingOrder, UnityEvent backKeyEvent, bool isUpdate);
		private void RemoveSortingOrder(int sortingOrder);
		public UnityAction GotoMyPageAction(Action onBeforeExitScene = null, float delay = 0f);
		public void SetBackKeyAsToMyPage(int sortingOrder, Action onBeforeExitScene = null, float delay = 0f);
		public void RemoveBackKeyEvent(int sortingOrder, bool isWithDict = false);
		public void ClearBackKeyEvent();
	}
}
