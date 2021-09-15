/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ExcludeSummonPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private ExcludeSummonCtrl tabCtrls;
		[SerializeField]
		private Transform sortButtonArea;
		[SerializeField]
		private Button allReleaseButton;
		[SerializeField]
		private Button allSelectButton;
		private GiftType type;
		private CommonSortButton sortButton;
		private int summonId;
		private SummonDataElement sde;
		private SummonTopItemData summonTopItemData;
		private UnityAction onSummonRequest;
	
		// Nested types
		[CompilerGenerated]
		private struct _Start_d__12 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ExcludeSummonPopup __4__this;
			private TaskAwaiter<SummonExcludeGetListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public ExcludeSummonPopup __4__this;
			public List<ulong> keyIds;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _OnSortButtonClicked_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<ExcludeSummonCellData> __9__17_0;
			public static Predicate<ExcludeSummonCellData> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SetrReleaseAndSelectButton_b__17_0(ExcludeSummonCellData x);
			internal bool _OnOkButton_b__18_0(ExcludeSummonCellData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _OnOkButton_b__1();
		}
	
		[CompilerGenerated]
		private struct _RequestSummonExcludeGetList_d__22 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<SummonExcludeGetListResponse> __t__builder;
			public ExcludeSummonPopup __4__this;
			private TaskAwaiter<SummonExcludeGetListResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public ExcludeSummonPopup();
	
		// Methods
		public static ExcludeSummonPopup Create(SummonTopItemData itemData, UnityAction onSummonRequest);
		private void Awake();
		protected override async void Start();
		private void UpdateSortAndFilter(int tabViewIndex);
		private void OnSortButtonClicked();
		private List<ulong> CreateDataIdList(GiftType giftType);
		public void UpdateItemList();
		private void SetrReleaseAndSelectButton();
		public void OnOkButton();
		public void OnSummonRequest();
		public void OnAllSelect();
		public void OnAllRelease();
		public async Task<SummonExcludeGetListResponse> RequestSummonExcludeGetList();
		[CompilerGenerated]
		[DebuggerHidden]
		private void __n__0();
	}
}
