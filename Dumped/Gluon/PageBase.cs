using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PageBase : AnimationUIObject
	{
		[SerializeField]
		private Button backButton;

		public bool removeTouchGuardOnActive;

		public SceneBase parentScene
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SceneNameDefine.PageName pageName
		{
			[CompilerGenerated]
			get
			{
				return default(SceneNameDefine.PageName);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void OnDestroy()
		{
		}

		public virtual void OnPageBecomeActive(object data)
		{
		}

		public virtual bool IsLoading()
		{
			return default(bool);
		}

		public virtual void OnPageEnterAnimationEnded()
		{
		}

		public virtual void OnPageBecomeInActive()
		{
		}

		public virtual void ChangePage(SceneNameDefine.PageName pageName, [Optional] Transform parentTransform, AnimationPattern exitPattern = AnimationPattern.Pattern_1, AnimationPattern enterPattern = AnimationPattern.Pattern_1, [Optional] Action<PageBase> onLoaded, [Optional] object data, bool delayEnterAnimation = true, bool deactivateLastPage = true)
		{
		}

		public virtual void ShowPage(bool toShow)
		{
		}

		public void RegisterBackKey(Canvas canvas, Button backButton)
		{
		}

		public void RemoveBackKey(Canvas canvas, Button backButton)
		{
		}
	}
}
