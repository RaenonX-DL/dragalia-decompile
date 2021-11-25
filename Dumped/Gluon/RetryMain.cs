using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.Events;

namespace Gluon
{
	public class RetryMain : SceneBase
	{
		private bool isHost;

		private int questId;

		private int lastQuestStartPlayerCount;

		private IEnumerator Start()
		{
			return null;
		}

		private void OnEnterScene()
		{
		}

		private IEnumerator LoadSceneMulti()
		{
			return null;
		}

		private void Disconnect()
		{
		}

		private bool CheckError()
		{
			return default(bool);
		}

		private void PopupHostExitConfirmCreate([Optional] UnityAction close)
		{
		}

		public void LoadBeforeQuestScene()
		{
		}

		private string GetNextSceneName()
		{
			return null;
		}
	}
}
