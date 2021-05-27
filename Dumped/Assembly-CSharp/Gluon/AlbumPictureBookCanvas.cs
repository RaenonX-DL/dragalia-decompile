/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureBookCanvas : AnimationUICanvas
	{
		// Fields
		[SerializeField]
		private AlbumPictureListController albumCtrl;
		[SerializeField]
		private CommonIconListBase iconListBase;
		[SerializeField]
		private TabBase tabBase;
		private CommonIconListType listType;
		[SerializeField]
		private UIAnimationPublisher uiAnimation;
		[SerializeField]
		private Button medalButton;
		public SimpleAnimationButton backButton;
		private AlbumPictureBookMedalPopup albumPictureBookMedalPopup;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _DelayLoadUnitDetail_d__9 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public AlbumPictureBookCanvas __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayLoadUnitDetail_d__9(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public AlbumPictureBookCanvas __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _LoadUnitDetailScene_b__0();
			internal void _LoadUnitDetailScene_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass14_0
		{
			// Fields
			public AlbumPictureBookCanvas __4__this;
			public bool oldStopState;
	
			// Constructors
			public __c__DisplayClass14_0();
	
			// Methods
			internal void _BackButtonFadeOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public AlbumPictureBookCanvas __4__this;
			public bool oldStopState;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _BakButtonFadeIn_b__0();
		}
	
		// Constructors
		public AlbumPictureBookCanvas();
	
		// Methods
		private void Start();
		[IteratorStateMachine]
		private IEnumerator DelayLoadUnitDetail();
		public void OnSelectedTab(int index);
		public void IconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		public void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void LoadUnitDetailScene(int masterId, CommonIconListType listType);
		public void BackButtonFadeOut();
		public void BakButtonFadeIn();
		public void ListRefresh();
		public void OnBonusPopupButton();
		public void OnMedalPopupButton();
		private void SetMedalButton();
		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, Action onAnimationDone = null, Action onCutOff = null);
		[CompilerGenerated]
		private bool _DelayLoadUnitDetail_b__9_0();
	}
}
