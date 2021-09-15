/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeSummonConfirmPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private ExcludeSummonConfirmCtrl excludeSummonConfirmCtrl;
		[SerializeField]
		private UnityEngine.UI.Text beforeStoneNum;
		[SerializeField]
		private UnityEngine.UI.Text afterStoneNum;
		[SerializeField]
		private UnityEngine.UI.Text okButtonText;
		private int summonId;
		private GiftType type;
		private List<ExcludeSummonCellData> excludeSummonCellDataList;
		private List<int> entityList;
		private SummonTopItemData summonTopItemData;
		private UnityAction onSummonRequest;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<ExcludeSummonCellData> __9__11_0;
			public static Predicate<ExcludeSummonCellData> __9__14_1;
			public static Action __9__16_0;
			public static Action<ErrorType, int> __9__16_1;
			public static Predicate<ExcludeSummonCellData> __9__17_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__11_0(ExcludeSummonCellData x);
			internal bool _OnSummonButton_b__14_1(ExcludeSummonCellData x);
			internal void _RequestSummonExcludeRequest_b__16_0();
			internal void _RequestSummonExcludeRequest_b__16_1(ErrorType errorType, int errorCode);
			internal bool _GetExcludeEntityList_b__17_0(ExcludeSummonCellData x);
		}
	
		[CompilerGenerated]
		private struct _RequestSummonExcludeGetOddsData_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<SummonExcludeGetOddsDataResponse> __t__builder;
			public ExcludeSummonConfirmPopup __4__this;
			private TaskAwaiter<SummonExcludeGetOddsDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _OnOddsButton_d__13 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ExcludeSummonConfirmPopup __4__this;
			private TaskAwaiter<SummonExcludeGetOddsDataResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public ExcludeSummonConfirmPopup __4__this;
			public Action CheckDrawingSufficiency;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnSummonButton_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_1
		{
			// Fields
			public CommonPopup popup;
			public __c__DisplayClass14_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass14_1();
	
			// Methods
			internal void _OnSummonButton_b__2();
			internal void _OnSummonButton_b__3();
		}
	
		[CompilerGenerated]
		private struct _RequestSummonExcludeRequest_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ExcludeSummonConfirmPopup __4__this;
			private TaskAwaiter<SummonExcludeRequestResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public ExcludeSummonConfirmPopup();
	
		// Methods
		public static ExcludeSummonConfirmPopup Create(SummonTopItemData itemData, List<ExcludeSummonCellData> list, UnityAction onSummonRequest);
		protected override void Start();
		private async Task<SummonExcludeGetOddsDataResponse> RequestSummonExcludeGetOddsData();
		public async void OnOddsButton();
		public void OnSummonButton();
		public void StoneUpdate();
		public async void RequestSummonExcludeRequest();
		private int[] GetExcludeEntityList();
	}
}
