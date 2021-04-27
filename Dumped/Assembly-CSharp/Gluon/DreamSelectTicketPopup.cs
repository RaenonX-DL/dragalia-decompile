/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DreamSelectTicketPopup : PopupBase
	{
		// Fields
		public const string path = "Prefabs/OutGame/ShopTrade/Popup/DreamSelectTicketPopup";
		[SerializeField]
		private DreamSelectTicketCtrl[] tabCtrls;
		[SerializeField]
		private TabBase tabView;
		[SerializeField]
		private float sortButtonPosY;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[HideInInspector]
		public ItemListPopup itemListPopup;
		private CommonSortButton sortButton;
		private int ticketId;
		private GiftTextLoader.NameAndDescription unitData;
	
		// Nested types
		[CompilerGenerated]
		private struct _Start_d__11 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public DreamSelectTicketPopup __4__this;
			private TaskAwaiter<ExchangeGetUnitListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public DreamSelectTicketPopup __4__this;
			public List<ulong> keyIds;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _OnSortButtonClicked_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public CommonIconPopup popup;
			public DreamSelectTicketPopup __4__this;
			public GiftType giftType;
			public int unitId;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnClickButton_b__0();
			internal void _OnClickButton_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public DreamSelectTicketPopup __4__this;
			public CommonIconPopup popup;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnSummonRequest_b__0();
		}
	
		[CompilerGenerated]
		private struct _OnSummonRequest_d__16 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public DreamSelectTicketPopup __4__this;
			public GiftType giftType;
			public int unitId;
			private __c__DisplayClass16_0 __8__1;
			private TaskAwaiter<ExchangeSelectUnitResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ExchangeGetUnitListRequest_d__17 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<ExchangeGetUnitListResponse> __t__builder;
			public int ticketId;
			private TaskAwaiter<ExchangeGetUnitListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _ExchangeSelectUnitRequest_d__18 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<ExchangeSelectUnitResponse> __t__builder;
			public GiftType giftType;
			public int id;
			public int ticketId;
			private TaskAwaiter<ExchangeSelectUnitResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public DreamSelectTicketPopup();
	
		// Methods
		public static DreamSelectTicketPopup Create(int ticketId);
		private void Awake();
		protected override async void Start();
		private List<ulong> CreateDataIdList(GiftType giftType);
		private void OnSortButtonClicked();
		private void UpdateSortAndFilter(int tabViewIndex);
		public void OnClickButton(GiftType giftType, int unitId);
		private async void OnSummonRequest(GiftType giftType, int unitId);
		private async Task<ExchangeGetUnitListResponse> ExchangeGetUnitListRequest(int ticketId);
		private async Task<ExchangeSelectUnitResponse> ExchangeSelectUnitRequest(int ticketId, GiftType giftType, int id);
		[CompilerGenerated]
		private void _Start_b__11_0(int index, bool calledFromUI);
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0();
	}
}
