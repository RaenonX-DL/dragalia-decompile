using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class MyPage2dUICanvas : AnimationUICanvas
	{
		public MyPageScene scene;

		public PageViewBase pageViewBase;

		public GameObject content;

		private List<int> characterIds;

		public static int pageIndex;

		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;

		private IEnumerator Start()
		{
			return null;
		}

		private void SetPage(GameObject page, int index)
		{
		}

		public void OnHide()
		{
		}

		public void OnFinishHide()
		{
		}

		private void SetMyPage2dCharacterClickAction(Action action)
		{
		}
	}
}
