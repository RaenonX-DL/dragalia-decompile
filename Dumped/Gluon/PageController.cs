using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class PageController : MonoBehaviour
	{
		private Dictionary<int, PageBase> pages;

		private int _delayFrame;

		public PageBase curPage
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int delayFrame
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public bool IsLoaded(SceneNameDefine.PageName pageName)
		{
			return default(bool);
		}

		public void LoadPage(SceneNameDefine.PageName pageName, Transform parentTransform, [Optional] Action<PageBase> onLoaded)
		{
		}

		public void ChangePage(SceneNameDefine.PageName pageName, Transform parentTransform, SceneBase parentScene, AnimationUICanvas.AnimationPattern exitPattern, AnimationUICanvas.AnimationPattern enterPattern, Action<PageBase> onLoaded, [Optional] object data, bool allowSamePageReload = true, bool delayEnterAnimation = true, bool deactivateLastPage = true)
		{
		}

		private IEnumerator WaitForStartingEnterAnimation(float delayTime, AnimationUICanvas.AnimationPattern enterPattern, AnimationUICanvas.AnimationPattern exitPattern, PageBase lastPage, PageBase thisPage, SceneBase parentScene, Action<PageBase> onLoaded, object data, bool deactivateLastPage)
		{
			return null;
		}

		public void RemoveCurPage(bool hasAnimation, AnimationUICanvas.AnimationPattern exitPattern = AnimationUICanvas.AnimationPattern.Pattern_1)
		{
		}

		public PageBase GetPage(SceneNameDefine.PageName pageName)
		{
			return null;
		}
	}
}
