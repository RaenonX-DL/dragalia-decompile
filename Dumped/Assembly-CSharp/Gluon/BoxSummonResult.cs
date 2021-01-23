/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BoxSummonResult : MonoBehaviour, ICustomMessage
	{
		// Fields
		[SerializeField]
		public GameObject resultItemTemplate;
		[SerializeField]
		private GameObject captionObj;
		[SerializeField]
		private GameObject bottomObj;
		[SerializeField]
		private Button resetButton;
		[SerializeField]
		private Button summonButton;
		[SerializeField]
		private UnityEngine.UI.Text summonButtonText;
		[SerializeField]
		private Button nextButton;
		[SerializeField]
		private UnityEngine.UI.Text nextButtonText;
		[SerializeField]
		private Button skipButton;
		[SerializeField]
		private UnityEngine.UI.Text pointRemain;
		[SerializeField]
		private UnityEngine.UI.Text pointCost;
		[SerializeField]
		private UnityEngine.UI.Text captionText;
		[SerializeField]
		private Image captionImage;
		[SerializeField]
		private Transform[] resultItemParents;
		[SerializeField]
		private BackButton backButton;
		[SerializeField]
		private UIAnimationPublisher enterPublisher;
		private List<GameObject> resultItems;
		public static readonly float NEXT_SUMMON_DELAY_START_TIME;
		public static readonly float NEXT_SUMMON_DELAY_WAIT_TIME;
		public static readonly float NEXT_SUMMON_DELAY_END_TIME;
		private BoxSummonAnimPage animPage;
		private Coroutine resultPopupCorutine;
		private BoxSummonResultPopup summonResultPopup;
		private bool summonContentsFromResult;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _ShowResultPopup_d__26 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonResult __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowResultPopup_d__26(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public AtgenBoxSummonResult summonResult;
	
			// Constructors
			public __c__DisplayClass36_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_1
		{
			// Fields
			public int i;
			public __c__DisplayClass36_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass36_1();
	
			// Methods
			internal bool _SetupItemList_b__1(AtgenBoxSummonDetail a);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<BoxSummonAnimScene.PickupItemInfo, int> __9__36_0;
			public static Func<BoxSummonDataElement, bool> __9__39_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _SetupItemList_b__36_0(BoxSummonAnimScene.PickupItemInfo x);
			internal bool _SetupPointCost_b__39_0(BoxSummonDataElement item);
		}
	
		[CompilerGenerated]
		private sealed class _nextSummon_d__49 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public BoxSummonResult __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _nextSummon_d__49(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BoxSummonResult();
		static BoxSummonResult();
	
		// Methods
		public void Show(bool toShow);
		public void SetContent(BoxSummonAnimPage animPage, bool isFadingOut);
		[IteratorStateMachine]
		private IEnumerator ShowResultPopup();
		private void ShowReceivedOverLimitPopup();
		private bool IsShowingResultPopup();
		protected void OnDestroy();
		private void OnEnable();
		private void OnDisable();
		private void Start();
		public void ResetSummonData();
		private void SetupContents();
		private void SetupCaption();
		private void SetupItemList();
		private void SetupItemListSub(AtgenDrawDetails drawInfo, int index, int total);
		private void SetupPointRemain();
		private void SetupPointCost();
		private void SetupResetButton();
		private void UpdateNextItems();
		private void TeardownContents();
		public void OnContentButtonTouched();
		public void OnBackButtonTouched();
		public void OnSummonButtonTouched();
		public void OnNextButtonTouched();
		public void OnSkipButtonTouched();
		private void ShowNextItems();
		[IteratorStateMachine]
		private IEnumerator nextSummon();
		private void StopResultPopupCorutine();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _Start_b__32_0();
		[CompilerGenerated]
		private void _OnSummonButtonTouched_b__45_0(bool execDemo);
		[CompilerGenerated]
		private void _ShowNextItems_b__48_0();
	}
}
