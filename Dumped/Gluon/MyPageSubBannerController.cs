using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class MyPageSubBannerController : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public RectTransform pagerCenter;

		public GameObject bannerRoot;

		[HideInInspector]
		public MyPageScene scene;

		private MyPageSubBanner dummyBanner;

		private List<MyPageSubBanner> banners;

		private List<CommonPager> pagers;

		private GameObject bannerPrefab;

		private Vector2 beginDragPosition;

		private bool isDragging;

		private bool isAnimating;

		private int currentIndex;

		private int bannerCount;

		private float lastMoveTime;

		private const float moveInterval = 8f;

		private const float bannerWidth = 280f;

		private const float resolutionFixRate = 100f;

		private void Awake()
		{
		}

		private IEnumerator InitCoroutine()
		{
			return null;
		}

		private MyPageBannerElement GetSummonBannerElement()
		{
			return null;
		}

		public void Reload()
		{
		}

		private void Update()
		{
		}

		private void CreateDummyBanner()
		{
		}

		private IEnumerator CreateDummyBannerCoroutine(MyPageBannerElement element)
		{
			return null;
		}

		private void AddBanner(MyPageBannerElement element)
		{
		}

		private IEnumerator AddBannerCoroutine(MyPageSubBanner.BannerInfo info, MyPageBannerElement element)
		{
			return null;
		}

		public void CloneBanner(MyPageSubBanner srcBanner)
		{
		}

		public void SetBannersEnable(bool enabled)
		{
		}

		private IEnumerator SetBannerEnableCoroutine(bool enabled)
		{
			return null;
		}

		private void CreatePagers(int pagerNum)
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnPressed()
		{
		}

		public void ShowNextStatusObject()
		{
		}

		public void ShowPrevStatusObject()
		{
		}

		public void SetAllPageOff()
		{
		}

		private void SetPageOn(int index)
		{
		}

		private void AddBanner(MyPageSubBanner banner)
		{
		}

		public bool IsExist()
		{
			return default(bool);
		}
	}
}
