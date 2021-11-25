using System.Collections;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventBannerController : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		public RectTransform pagerCenter;

		public GameObject bannerRoot;

		public Text titleText;

		public CircleOutline outline;

		private List<QuestEventSubBanner> banners;

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

		private readonly Color normalTextColor;

		private readonly Color normalOutlineColor;

		private readonly Color eventTextColor;

		private readonly Color eventOutlineColor;

		private void Start()
		{
		}

		private IEnumerator InitCoroutine()
		{
			return null;
		}

		public void Reload()
		{
		}

		private void Update()
		{
		}

		private void AddBanner(EventDataElement element)
		{
		}

		private IEnumerator AddBannerCoroutine(EventDataElement element)
		{
			return null;
		}

		public void CloneBanner(QuestEventSubBanner srcBanner)
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

		public void SetTitleText(string str)
		{
		}

		public void SetTextColor()
		{
		}

		public void SetAllPageOff()
		{
		}

		private void SetPageOn(int index)
		{
		}

		private void AddBanner(QuestEventSubBanner banner)
		{
		}

		public bool IsExist()
		{
			return default(bool);
		}
	}
}
