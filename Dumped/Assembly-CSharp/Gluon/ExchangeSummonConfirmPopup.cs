/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExchangeSummonConfirmPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform commonIconTrans;
		[SerializeField]
		private UnityEngine.UI.Text detailText;
		[SerializeField]
		private UnityEngine.UI.Text beforeExchangeItemCount;
		[SerializeField]
		private UnityEngine.UI.Text afterExchangeItemCount;
		[SerializeField]
		private Button exchangeButton;
		private SummonDataElement sde;
		private int summonId;
		private int entityId;
		private int tradeId;
		private UnityAction<int, int, int> onExchange;
		private ExchangeSummonSelectItemCellData data;
	
		// Nested types
		[CompilerGenerated]
		private struct _Request_d__15 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ExchangeSummonConfirmPopup __4__this;
			private TaskAwaiter<SummonSummonPointTradeResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public ExchangeSummonConfirmPopup();
	
		// Methods
		public static ExchangeSummonConfirmPopup Create(ExchangeSummonSelectItemCellData data, UnityAction<int, int, int> onExchange);
		public void SetContent(ExchangeSummonSelectItemCellData data, UnityAction<int, int, int> onExchange);
		public void OnExchangeButton();
		private void Exchange();
		public async void Request();
	}
}
