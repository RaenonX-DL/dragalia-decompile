using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class HeaderMessageBase<T> : MonoBehaviour where T : MessageDataBase
	{
		public Text title;

		public Text desc;

		public ThemeColorImageSwitcher imageSwitcher;

		public RectTransform rectTransform;

		public float initialY;

		public float middleY;

		public float lastY;

		public float initialFrame;

		public float waitFrame;

		public float lastFrame;

		protected static bool isShowing;

		protected Coroutine showNoticeCoroutine;

		protected Coroutine waitForOtherNoticeCoroutine;

		protected static List<T> messageDataList;

		public const int maxMessage = 5;

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public void ShowNotice()
		{
		}

		protected virtual bool isShowOtherNotice()
		{
			return default(bool);
		}

		private IEnumerator WaitForOtherNotice()
		{
			return null;
		}

		protected virtual bool IsWaitNeeded()
		{
			return default(bool);
		}

		private IEnumerator AnimationLoop(float delay = 0f)
		{
			return null;
		}

		protected virtual void UpdateMessageUI(T messageData)
		{
		}
	}
}
