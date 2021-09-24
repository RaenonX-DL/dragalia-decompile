/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TotalDamageEventHistoryPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform layoutParent;
		[SerializeField]
		private GameObject emptyDataText;
		private GameObject originalCell;
		private int eventId;
		private static readonly string totalDamageEventHistoryPopupPath;
		private static readonly string totalDamageEventHistoryCellPath;
	
		// Nested types
		[CompilerGenerated]
		private struct _RequestTotalDamageHistoryData_d__7 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public TotalDamageEventHistoryPopup __4__this;
			private TaskAwaiter<EventDamageGetTotalDamageHistoryResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _UpdateContents_d__8 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public TotalDamageEventHistoryPopup __4__this;
			private TaskAwaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public TotalDamageEventHistoryPopup();
		static TotalDamageEventHistoryPopup();
	
		// Methods
		public static TotalDamageEventHistoryPopup Create(int eventId);
		private async Task RequestTotalDamageHistoryData();
		private async Task UpdateContents();
	}
}
