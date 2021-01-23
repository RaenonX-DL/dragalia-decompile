/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using DG.Tweening;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactShopPanel : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public DragonStrokeMain contactMain;
		public RectMask2D maskPanel;
		public PageViewBase pageView;
		public GameObject pagerArrowParent;
		public UnityEngine.UI.Text noOwnedItemText;
		public TabBase tabController;
		[SerializeField]
		private AnimationUIBase presentButton;
		[Header]
		[SerializeField]
		public Transform[] shopIconParent;
		private List<ContactGiftIcon> shopIcons;
		private List<ContactGiftIcon> selectShopIcons;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text ownedCoinText;
		public AnimationUIBase ownedCoinAnimation;
		[Header]
		[SerializeField]
		public GameObject descriptionPanel;
		public CommonIcon descriptionIcon;
		public UnityEngine.UI.Text descriptionTitle;
		public UnityEngine.UI.Text descriptionText;
		public UnityEngine.UI.Text shopRestockText;
		[Header]
		[SerializeField]
		public Transform consumeBorderLine;
		public Transform consumeEndingPosition;
		private PageScrollViewRect pageViewScrollRect;
		private float maskPanelInitialHeight;
		private const float maskExpansionDuration = 0.2f;
		private const float descriptionPanelMoveDistance = 120f;
		private const float descriptionPanelMoveTime = 0.3f;
		public UnityEvent onExit;
		private Sequence runningPanelSequence;
		private bool firstOwnedSimpleAnimationDone;
		private const string ownedPagePrefabPath = "Prefabs/OutGame/DragonContact/Top/ContactOwnedGiftPage";
		private const string contactGiftIconPrefabPath = "Prefabs/OutGame/DragonContact/Top/ContactShopGiftIcon";
		[HideInInspector]
		public ContactGiftIcon beginDragGiftIcon;
		private ContactGiftIcon potentialBeginDragGiftIcon;
		private bool isVerticalDragging;
		private List<DragonGiftList> dragonGiftList;
		private tabType tabIndex;
	
		// Nested types
		private enum tabType
		{
			shop = 0,
			gift = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass50_0
		{
			// Fields
			public ContactShopPanel __4__this;
			public ContactOwnedGiftPage page;
	
			// Constructors
			public __c__DisplayClass50_0();
	
			// Methods
			internal void _SetExtraGiftPageContent_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass51_0
		{
			// Fields
			public ContactShopPanel __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass51_0();
	
			// Methods
			internal void _EnterPanel_b__0(float val);
			internal void _EnterPanel_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ExitPanelWithDelayCoroutine_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delayTime;
			public ContactShopPanel __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ExitPanelWithDelayCoroutine_d__55(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public ContactShopPanel __4__this;
			public TouchGuardObject touchGuard;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _ExitPanel_b__0(float val);
			internal void _ExitPanel_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass63_0
		{
			// Fields
			public ContactGiftIcon icon;
	
			// Constructors
			public __c__DisplayClass63_0();
	
			// Methods
			internal bool _AddSelectIcon_b__0(ContactGiftIcon x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass64_0
		{
			// Fields
			public ContactGiftIcon icon;
	
			// Constructors
			public __c__DisplayClass64_0();
	
			// Methods
			internal bool _RemoveSelectIcon_b__0(ContactGiftIcon x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public TouchGuardObject touchGuard;
			public ContactShopPanel __4__this;
			public List<int> selectIdList;
			public Action __9__0;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _SendItemsAnimation_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SendItemsAnimation_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public ContactShopPanel __4__this;
			private __c__DisplayClass69_0 __8__1;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SendItemsAnimation_d__69(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public ContactGiftIcon icon;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal bool _ResetIconsColor_b__0(ContactGiftIcon x);
		}
	
		// Constructors
		public ContactShopPanel();
	
		// Methods
		public void Awake();
		private void Start();
		private void InitializeShopIcons();
		private ContactGiftIcon CreateShopIcon(Transform parent);
		private void SetIconAnimation(ContactGiftIcon icon, int index);
		private void OnCustomVerticalEndDrag(PointerEventData eventData);
		private void OnCustomVerticalPotentialBeginDrag(PointerEventData eventData);
		public void OnCustomVerticalDrag(PointerEventData eventData);
		public void OnTabSwitched(int index, bool fromUI);
		private void PutInCoinAndButton();
		private void PutOutCoinAndButton();
		private void ResetPresentButtonInteractable();
		public void RefreshPanel();
		private void OnPageChanged(int index);
		private void SetOwnedGiftPageContent(GameObject pageGO, int index);
		private void SetExtraGiftPageContent(GameObject pageGO, int index);
		public void EnterPanel();
		private void EnterExtraPanel();
		private void ResetExtraPanel();
		public void ExitPanelWithDelay(float delayTime);
		[IteratorStateMachine]
		private IEnumerator ExitPanelWithDelayCoroutine(float delayTime);
		public void ExitPanel();
		public void showItemDescription(int id);
		public void hideItemDescription();
		public bool IsOpenDescription(int id);
		public void OnGiftSent(bool favorite);
		public void OnBeforeSendGift();
		public void DeselectAll();
		public void AddSelectIcon(ContactGiftIcon icon);
		public void RemoveSelectIcon(ContactGiftIcon icon);
		private void ResettingSelectImages();
		private void RemoveAllSelectIcon();
		public void OnPresentButtonPressed();
		private void SendPresent();
		[IteratorStateMachine]
		private IEnumerator SendItemsAnimation();
		public void ApiBuyGiftToSendMultiple(int[] idList);
		public void ApiOnBuyGiftToSendMultipleError(ErrorType errorType, int errorCode);
		private void ApiOnBuyGiftToSendMultipleSuccess(DragonBuyGiftToSendMultipleResponse res);
		private bool HasFavoriteGift(AtgenDragonGiftRewardList[] rewardList);
		private void ImportReturnGiftData(AtgenDragonGiftRewardList[] rewardList);
		public List<DragonGiftList> GetDragonGiftList();
		public long GetRemainingCoin();
		private void ResetShopState();
		private void ResetIconsColor();
		private void ResetSlider();
		public bool IsSelectMultipleIcons();
		[CompilerGenerated]
		private void _OnPresentButtonPressed_b__67_0();
	}
}
