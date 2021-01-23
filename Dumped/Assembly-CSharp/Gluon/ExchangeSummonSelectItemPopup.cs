/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExchangeSummonSelectItemPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private ExchangeSummonSelectItemCtrl[] tabCtrls;
		[SerializeField]
		private TabBase tabView;
		[SerializeField]
		private UnityEngine.UI.Text detailText;
		[SerializeField]
		private UnityEngine.UI.Text periodText;
		[SerializeField]
		private Transform sortButtonArea;
		[SerializeField]
		private UnityEngine.UI.Text nowSummonPointText;
		private CommonSortButton sortButton;
		private int summonId;
		private SummonDataElement sde;
		private SummonPointDataElement spde;
		private bool isSentToPresentBox;
		private DateTime endScheduleDateTime;
		public Action onClose;
	
		// Nested types
		[CompilerGenerated]
		private struct _Request_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public int summonId;
			public ExchangeSummonSelectItemPopup __4__this;
			private TaskAwaiter<SummonGetSummonPointTradeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass21_0
		{
			// Fields
			public ExchangeSummonSelectItemPopup __4__this;
			public List<ulong> keyIds;
	
			// Constructors
			public __c__DisplayClass21_0();
	
			// Methods
			internal void _OnSortButtonClicked_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public CommonIconPopup iconPopup;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _OnExchangeSuccess_b__0();
		}
	
		// Constructors
		public ExchangeSummonSelectItemPopup();
	
		// Methods
		public static ExchangeSummonSelectItemPopup Create(int summonId, DateTime completeDateTime);
		private void Awake();
		protected override void Start();
		public async void Request(int summonId);
		public void UpdateItemList();
		public void OnSummonSummonPointTradeRequestError(ErrorType errorType, int errorCode);
		private List<ulong> CreateDataIdList(GiftType giftType);
		private void UpdateSortAndFilter(int tabViewIndex);
		private void OnSortButtonClicked();
		public void OnSummonClick(ExchangeSummonSelectItemCellData data);
		public void OnExchangeSuccess(int summonId, int id, int giftType);
		public void ExchangePopupClose();
		[CompilerGenerated]
		private void _Start_b__15_0(int index, bool calledFromUI);
	}
}
