/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PageViewBase : MonoBehaviour
	{
		// Fields
		public PageViewType pageViewType;
		public Transform contentParent;
		[SerializeField]
		private PageScrollViewRect scrollRect;
		public bool showLeftRightArrows;
		[SerializeField]
		public Button leftArrowButton;
		[SerializeField]
		public Button rightArrowButton;
		public bool showPager;
		[SerializeField]
		public GameObject pagerCenter;
		[SerializeField]
		public float pagerWidth;
		public bool enablePagerPress;
		[SerializeField]
		public bool shouldAutoExpandScrollRect;
		[HideInInspector]
		public bool isDisableCheckMoveToPageWhenIsTouchGuardEnable;
		protected List<CommonPager> pagers;
		protected int _currentPageIndex;
		protected List<GameObject> pages;
		public const int constCachedPageCount = 3;
		private int _cachedPageCount;
		protected int _pageCount;
		private bool _canScroll;
		public Action onBeforeMovePage;
		public Action<int> onBeforePagerSelect;
		private bool isMoveNextPage;
		public Action<int> onPageChanged;
		public Action<int> onPageReadyToChange;
		public Action<bool> onBeforeMovingCurrentPage;
		public Action<bool> onBeforeMovingNewPage;
		[CompilerGenerated]
		private bool _isNewPageComing_k__BackingField;
		private int startIndex;
		public bool isResetPage;
		public Action<GameObject, int> setContentCallback;
		public bool isCycle;
		public bool enableQuickFlipToChangePage;
		public bool isPreIn;
		public bool isLoading;
		[Header]
		[SerializeField]
		public bool hasFadeWhileChangingPage;
		public float fadeDuration;
		public float delayFadeInTime;
		[Header]
		[SerializeField]
		public bool hasMoveBackAnimation;
		[Header]
		[SerializeField]
		public float autoFadeWidth;
		private float autoFadeCellWidth;
		[SerializeField]
		public List<MaintenanceFunctionType> maintenanceTypes;
	
		// Properties
		public float animationDuration { get; }
		public int currentPageIndex { get; protected set; }
		public GameObject currentPage { get; }
		public GameObject rightPage { get; }
		public GameObject leftPage { get; }
		public int cachedPageCount { get; }
		public int pageCount { get; private set; }
		public int rawPageCount { get; }
		public bool canScroll { get; set; }
		public bool isNewPageComing { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum PageViewType
		{
			Normal = 0,
			OnePage = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass86_0
		{
			// Fields
			public CanvasGroup canvasGroup;
	
			// Constructors
			public __c__DisplayClass86_0();
	
			// Methods
			internal void _FadePage_b__0();
		}
	
		// Constructors
		public PageViewBase();
	
		// Methods
		public PageScrollViewRect GetScrollRect();
		private void Start();
		private void OnDestroy();
		public virtual void RemoveAllPages(bool immediately = false);
		public void SetPageWidthToFullScreen(GridLayoutGroup gridLayoutGroup, Canvas canvas, float space = 0f, float keepMinimumSize = 0f);
		public void InitPages(GameObject prefab, int pageCount, int startPageIndex, Action<GameObject, int> setContentCallback);
		public void Reset();
		public void SetContentCallback(Action<GameObject, int> callback);
		private void CreatePages(GameObject prefab);
		public void SetStartPage(int index);
		private void SetHorizontalNormalizedPosition(float position, bool updateStartX = false);
		public void CheckMoveToPage(bool isNextPage, bool fromDragging);
		public void CheckMoveToPage(bool isNextPage);
		public void PlayMoveToPage();
		public void MoveToPreviousPage(bool fromDragging);
		private void MoveToPreviousPage(int index, bool fromDragging);
		public void MoveToNextPage(bool fromDragging);
		private void MoveToNextPage(int index, bool fromDragging);
		public void MoveToNextPage();
		public void MoveToPreviousPage();
		private void FadePage(GameObject go, bool isFadeIn, float delay = 0f);
		protected virtual void CreatePager();
		protected void OnPagerPressed(int pageIndex);
		public void MovePagerPage(int index);
		protected virtual void UpdatePager();
		private void UpdateArrows();
		public void UpdatePages(int indexDelta);
		public GameObject GetRawPageAtIndex(int index);
		public void SetArrowPosOffetY(float offsetY);
		public void SetPageArrow(Button rightButton, Button leftBUtton);
		public void SetArrowButtonEnable(bool isLock);
		private void OnPageOrScrollPositionChangedForAutoFade();
		[CompilerGenerated]
		private void _Start_b__67_0(int x);
		[CompilerGenerated]
		private void _Start_b__67_1(Vector2 x);
		[CompilerGenerated]
		private void _CreatePager_b__87_0(int index);
		[CompilerGenerated]
		private void _SetPageArrow_b__95_0();
		[CompilerGenerated]
		private void _SetPageArrow_b__95_1();
	}
}
