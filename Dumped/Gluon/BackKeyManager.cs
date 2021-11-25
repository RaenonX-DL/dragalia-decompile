using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Events;

namespace Gluon
{
	public class BackKeyManager : SingletonMonoBehaviour<BackKeyManager>
	{
		protected List<int> sortingOrders;

		protected Dictionary<int, UnityEvent> eventDict;

		public int tempSortingOrder;

		public static DateTime lastTouchDownDateTime;

		public float doubleTouchThreshold;

		public bool isEnableBackkey;

		protected bool isAndroid;

		public bool canCheckTutorialStatus
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Update()
		{
		}

		protected override void Awake()
		{
		}

		public void OnPressedBackKey()
		{
		}

		public void AddSortingOrder(int sortingOrder)
		{
		}

		public int GetSortingOrderNum()
		{
			return default(int);
		}

		public void SetBackKeyEvent(int sortingOrder, UnityEvent backKeyEvent, bool isUpdate)
		{
		}

		private void RemoveSortingOrder(int sortingOrder)
		{
		}

		public UnityAction GotoMyPageAction([Optional] Action onBeforeExitScene, float delay = 0f)
		{
			return null;
		}

		public void SetBackKeyAsToMyPage(int sortingOrder, [Optional] Action onBeforeExitScene, float delay = 0f)
		{
		}

		public void RemoveBackKeyEvent(int sortingOrder, bool isWithDict = false)
		{
		}

		public void ClearBackKeyEvent()
		{
		}
	}
}
