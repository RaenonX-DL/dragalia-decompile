/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleIconListCanvas : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public CommonIconListBase commonIconListBase;
		private Canvas canvas;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public CommonIconListCellData data;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _IconButtonPressed_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CommonListCustomSortData, CommonListCustomSortData> __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal CommonListCustomSortData _LoadBaseListData_b__8_0(CommonListCustomSortData data);
		}
	
		[CompilerGenerated]
		private sealed class _LoadBaseListData_d__8 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleIconListCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBaseListData_d__8(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private struct _DisableScrollRect_d__9 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthManaCircleIconListCanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthManaCircleIconListCanvas();
	
		// Methods
		private void Start();
		private void OnDestroy();
		public void OnOtherAreaPressed();
		private void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		[IteratorStateMachine]
		private IEnumerator LoadBaseListData();
		private async void DisableScrollRect();
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList();
		[CompilerGenerated]
		private void _Start_b__3_0();
	}
}
