using UnityEngine;

namespace Gluon
{
	public class AndroidStatusBarController
	{
		private static AndroidJavaObject plugin;

		public int visibleDisplayHeight => default(int);

		public int displayHeight => default(int);

		public int visibleDisplayWidth => default(int);

		public int cutoutHeight => default(int);

		public int displayWidth => default(int);

		public int statusBarHeight => default(int);

		public int navigationBarHeight => default(int);

		public int realSizeHeight => default(int);

		public int gpgsVersion => default(int);

		static AndroidStatusBarController()
		{
		}

		public bool isEnableEditSystemUI()
		{
			return default(bool);
		}

		public void Show()
		{
		}

		public bool isFullScreenMode()
		{
			return default(bool);
		}

		public void fullScreenMode()
		{
		}

		public bool isHideStatusBar()
		{
			return default(bool);
		}

		public void hideStatusBar()
		{
		}

		public bool isHideNavigationBar()
		{
			return default(bool);
		}

		public void hideNavigationBar()
		{
		}

		public void hideActionBar()
		{
		}

		public void showActionBar()
		{
		}

		public void RefreshLayout()
		{
		}

		public void ForceLayout()
		{
		}

		public void ClearFlags()
		{
		}
	}
}
