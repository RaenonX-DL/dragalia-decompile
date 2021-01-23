/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCrestSetPopup : CommonPopup
	{
		// Fields
		public const int maxSetCountInGroup = 6;
		public TabBase setGroupTab;
		public Transform listParentTransform;
		public GameObject originCell;
		public Action<int> selectCrestSetCallBack;
		private PartyCrestSetPopupCell[] cells;
		private int selectGroupIndex;
	
		// Nested types
		[CompilerGenerated]
		private struct _SendRegistData_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int setIndex;
			public PartyCrestSetPopup __4__this;
			private TaskAwaiter<AbilityCrestSetAbilityCrestSetResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public PartyCrestSetPopup();
	
		// Methods
		public static PartyCrestSetPopup Create();
		public void InitPopup();
		public override void StartShowAnimation(UnityEvent onCompleted = null);
		private void OnSelectedGroupTab(int index);
		private void ReloadCell();
		private async void SendRegistData(int setIndex);
		private AtgenRequestAbilityCrestSetData CreateRegistData(int setIndex);
		private void SelectCrestSet(int setIndex);
		[CompilerGenerated]
		private void _StartShowAnimation_b__9_0();
	}
}
