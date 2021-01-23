/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GuildReportDetailPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public InputField commentInput;
		public UnityEngine.UI.Text maxCharText;
		public UnityEngine.UI.Text inputCharText;
		public UnityEngine.UI.Text selectCategoryText;
		public Button okButton;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReportDetailPopup";
		private Action<bool> onAnyActionDone;
		private GuildReportConfirmPopup.ReportData reportData;
		private CommonReportCategoryElement[] _cats;
		private const int maxChar = 200;
		private int selectCategoryListIndex;
	
		// Properties
		private CommonReportCategoryElement[] cats { get; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CommonReportCategoryElement, int> __9__10_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _get_cats_b__10_0(CommonReportCategoryElement x);
		}
	
		[CompilerGenerated]
		private struct _RequestPostReport_d__20 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildChatPostReportResponse> __t__builder;
			public GuildReportDetailPopup __4__this;
			public string message;
			public int cateoryId;
			private TaskAwaiter<GuildChatPostReportResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private struct _RequestCommonPostReport_d__21 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder<GuildPostReportResponse> __t__builder;
			public GuildReportDetailPopup __4__this;
			public string message;
			public int cateoryId;
			private TaskAwaiter<GuildPostReportResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public GuildReportDetailPopup __4__this;
			public DrumScrollPopup popup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _OnCategorySelectButtonPressed_b__0(int index, GameObject obj);
			internal void _OnCategorySelectButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private struct __OnOkButtonPressed_b__16_0_d : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GuildReportDetailPopup __4__this;
			private TaskAwaiter<GuildChatPostReportResponse> __u__1;
			private TaskAwaiter<GuildPostReportResponse> __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GuildReportDetailPopup();
	
		// Methods
		public static GuildReportDetailPopup Create(GuildReportConfirmPopup.ReportData reportData, Action<bool> onAnyActionDone);
		protected override void Start();
		public void OnCloseButtonPressed();
		public void OnOkButtonPressed();
		private void SetInputChar(int count);
		public void OnValueChanged(string text);
		public void OnEndEdit(string text);
		private async Task<GuildChatPostReportResponse> RequestPostReport(string message, int cateoryId);
		private async Task<GuildPostReportResponse> RequestCommonPostReport(string message, int cateoryId);
		public void OnCategorySelectButtonPressed();
		[CompilerGenerated]
		private void _OnCloseButtonPressed_b__15_0();
		[CompilerGenerated]
		private async void _OnOkButtonPressed_b__16_0();
		[CompilerGenerated]
		private void _OnOkButtonPressed_b__16_1();
	}
}
