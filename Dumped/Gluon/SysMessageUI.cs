using UnityEngine;

namespace Gluon
{
	public class SysMessageUI : CommonDialog
	{
		private Param param;

		private bool isShowCloseAppPop;

		public static SysMessageUI CreateSysMessage(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		public void Open(bool modal, string text, string title = "", int fontSize = 0, bool raycast = true)
		{
		}

		protected override void ExecFirstButtonPressed()
		{
		}

		private void CreateCloseAppPop()
		{
		}
	}
}
