using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cute.Http;
using Gluon.Master;
using NPF;
using NPF.User;

namespace Gluon
{
	public class HttpHelper
	{
		public static class HttpTask<T1, T2>
		{
			public static Func<T1, Action<T2>, Action<ErrorType, int, T2>, IHttpTask> Create;
		}

		private const int retryExpireTime = 7200;

		private static Action onCloseCallback;

		private static bool afterSignup;

		private static long request_id;

		private static bool isHttpManagerGetErrorCodeFuncInitialized;

		public static Action OnCloseCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static long GenerateRequestToken()
		{
			return default(long);
		}

		private static int GetRequestTime(long token)
		{
			return default(int);
		}

		private static bool IsRetryAvailable(int n)
		{
			return default(bool);
		}

		public static T Create<T>() where T : new()
		{
			return (T)null;
		}

		public static void Send<T1, T2>(T1 req, Action<T2> onSuccess, [Optional] Action<ErrorType, int> onError, bool auth = false) where T2 : class
		{
		}

		public static void SendSilently<T1, T2>(T1 req, Action<T2> onSuccess, bool auth = false) where T2 : class
		{
		}

		private static void Send<T1, T2>(T1 req, bool ignoreError, bool createOnConnectCanvas, Action<T2> onSuccess, [Optional] Action<ErrorType, int> onError, bool auth = false) where T2 : class
		{
		}

		public static Task<T2> SendAsync<T2, T1>(T1 req, [Optional] Action<ErrorType, int> onError, bool auth = false) where T2 : class
		{
			return null;
		}

		public static Task<T2> SendSilentlyAsync<T2, T1>(T1 req, bool auth = false) where T2 : class
		{
			return null;
		}

		private static Task<T2> SendAsync<T2, T1>(T1 req, bool ignoreError = false, bool createOnConnectCanvas = true, [Optional] Action<ErrorType, int> onError, bool auth = false) where T2 : class
		{
			return null;
		}

		private static IEnumerator DelayOneSec(Action next)
		{
			return null;
		}

		private static void OpenOnConnectCanvas()
		{
		}

		private static void CloseOnConnectCanvas()
		{
		}

		public static void BackToTitle()
		{
		}

		public static void BackToMyPage()
		{
		}

		public static void BackToParty()
		{
		}

		public static void BackToDownload()
		{
		}

		public static void BackToQuit()
		{
		}

		public static void GoToLoginBonus()
		{
		}

		public static void GoToTutorialSummon()
		{
		}

		private static void ShowInquiryPopup()
		{
		}

		public static SystemMessageElement GetSystemMessageElement(int resultCode)
		{
			return null;
		}

		public static Action GetAction(int resultCode)
		{
			return null;
		}

		private static void Retry(int requestTime)
		{
		}

		public static void OnError(ErrorType type, int n, [Optional] Action<ErrorType, int> onError)
		{
		}

		private static void NpfBaaSAuthCallback(BaaSUser user, NPFError error)
		{
		}

		private static void NpfBaaSReauthCallback(BaaSUser user, NPFError error)
		{
		}

		private static void ApplicationVersionError()
		{
		}

		public static void ClearCache<T>() where T : IHttpTask
		{
		}

		public static void Auth([Optional] Action next, bool force = false, bool interruptAuthTask = false)
		{
		}

		private static void ReAuth([Optional] Action next)
		{
		}

		public static void UpdatePushNotificationInfo(Action next)
		{
		}

		public static bool IsAssetBundleBuildNumberSpecifiedByDebugCommand()
		{
			return default(bool);
		}

		public static string GetAssetBundleBuildNumber()
		{
			return null;
		}

		private static void GetDeployVersion(Action next, bool interrupt = false)
		{
		}

		public static void GetResourceVersion(Action next)
		{
		}

		private static void GetResourceVersionImpl(Action next)
		{
		}

		public static void Signup(Action next, string lang = "ja_jp", string region = "JP", int eulaVersion = 1, int privacyVersion = 1)
		{
		}

		public static void SetupDefaultHeader()
		{
		}

		public static void LoadIndex(Action next, bool isForce = false)
		{
		}

		public static void LoginIndex(Action next, bool afterPrologue = false)
		{
		}

		private static void GetSafetyNetStatus(Action<Action, Action<ErrorType, int>, string> callback, Action next)
		{
		}

		private static void SendLoginIndex(Action onSuccess, [Optional] Action<ErrorType, int> onError, [Optional] string jws_result)
		{
		}

		private static void SendLoginVerifyJws(Action onSuccess, Action<ErrorType, int> onError, string jws_result)
		{
		}

		public static void LoginVerifyJws(Action next, [Optional] string jws_result)
		{
		}

		public static void Login(Action next)
		{
		}

		private static void OnUnableToContinueError()
		{
		}

		private static void PauseIngame(bool pause)
		{
		}

		private static bool IsNoSessionApi(Type taskType)
		{
			return default(bool);
		}

		static HttpHelper()
		{
		}
	}
}
