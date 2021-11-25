using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class BootScene : MonoBehaviour
	{
		private static bool isScreenInitialized;

		private static bool isMessagePackInitialized;

		private int screenHeight;

		private NPFEventHandlerImpl NPFEventhandler;

		[RuntimeInitializeOnLoadMethod]
		private static void Initialize()
		{
		}

		public static void SetMessagePackRegister()
		{
		}

		private void Awake()
		{
		}

		private IEnumerator GameStart()
		{
			return null;
		}

		private IEnumerator GotoNextScene()
		{
			return null;
		}

		private void InitializeDebug()
		{
		}
	}
}
