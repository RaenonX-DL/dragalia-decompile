/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRGatherItemLimitPopup : PopupBase
	{
		// Fields
		[SerializeField]
		public CommonIcon icon;
		public UnityEngine.UI.Text titleText;
		public UnityEngine.UI.Text commentText;
		private int id;
		private string itemName;
		private int lastResetTime;
		private Action onDone;
		private const string prefabPath = "Prefabs/OutGame/QuestResult/Popup/QRGatherItemLimitPopup";
		private const string prefGatherItemLimitTemplate = "__QRGatherItem_{0}";
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public TaskCompletionSource<bool> done;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _ShowGatherItemLimitPopupIfNeeded_b__0();
		}
	
		[CompilerGenerated]
		private struct _ShowGatherItemLimitPopupIfNeeded_d__9 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncUniTaskMethodBuilder __t__builder;
			private int _count_5__2;
			private int _i_5__3;
			private TaskAwaiter<bool> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public QRGatherItemLimitPopup();
	
		// Methods
		public static async UniTask ShowGatherItemLimitPopupIfNeeded();
		public static QRGatherItemLimitPopup Create(int id, string name, int lastResetTime, Action onDone);
		protected override void Start();
		public void OnCloseButtonPressed();
	}
}
