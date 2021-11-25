using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OmotePlugin : MonoBehaviour
{
	public delegate void OnNotifyEnabledReceivedEventHandler(bool enabled);

	[Serializable]
	private class OmotenashiFirebaseOptions
	{
		public string ApiKey;

		public string ProjectId;

		public string ApplicationId;

		public string SenderId;
	}

	public delegate void OmoteEventHandler<in TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs;

	public class RequestResultEventArgs : EventArgs
	{
		internal class RawData
		{
			public int type;

			public int result;

			public string body;

			public string endpoint;

			public int statusCode;

			public string reason;
		}

		public int Type
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Result
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Body
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

		public string EndPoint
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

		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Reason
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

		internal RequestResultEventArgs(RawData data)
		{
		}
	}

	public class LocalNotification
	{
		private static readonly DateTime UnixEpoch;

		public string Message
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

		public DateTime When
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string LabelId
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

		public LocalNotificationPriority Priority
		{
			[CompilerGenerated]
			get
			{
				return default(LocalNotificationPriority);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int NotificationId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Title
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

		public string ExtraText
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

		public string ImagePath
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

		public LocalNotification(string message, DateTime when, string labelId)
		{
		}

		public void Schedule()
		{
		}

		public void Cancel()
		{
		}

		public static void Cancel(string labelId)
		{
		}

		public static void CancelAll()
		{
		}
	}

	public class RegistrationTokenEventArgs : EventArgs
	{
		public string RegistrationToken
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
	}

	public class PushNotificationEventArgs : EventArgs
	{
		internal class RawData
		{
			public string id;

			public string message;

			public string extra;
		}

		public string Id
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

		public string Message
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

		public string Extra
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

		internal PushNotificationEventArgs(RawData data)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class LocalNotificationEventArgs : EventArgs
	{
		internal class RawData
		{
			public string scheduleId;

			public string label;

			public string scheduled;

			public string message;

			public string extra;
		}

		public string ScheduleId
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

		public string LabelId
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

		public DateTime ScheduledAt
		{
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string MessageText
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

		public string ExtraText
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

		internal LocalNotificationEventArgs(RawData data)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public class NotificationChangedEventArgs : EventArgs
	{
		internal class RawData
		{
			public bool result;
		}

		public bool Result
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal NotificationChangedEventArgs(RawData data)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	public delegate void OnRegistrationTokenReceivedEventHandler(object sender, RegistrationTokenEventArgs e);

	public delegate void OnFailToRegisterForRemoteNotificationsEventHandler(object sender, string e);

	private AndroidJavaObject mOmotePluginBaseBridge;

	[SerializeField]
	private bool IsAutomatic;

	[SerializeField]
	private OmotenashiFirebaseOptions omotenashiFirebaseOptions;

	internal static AndroidJavaObject mOmotePluginPushBridge;

	private static bool mStartPushCalled;

	public string country;

	public event OnNotifyEnabledReceivedEventHandler OnNotificationRecetived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<RequestResultEventArgs> OnRequestResult
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnRegistrationTokenReceivedEventHandler OnRegistrationTokenReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<PushNotificationEventArgs> OnReceivedPushNotification
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<LocalNotificationEventArgs> OnReceivedLocalNotification
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<PushNotificationEventArgs> OnLaunchFromPushNotification
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<LocalNotificationEventArgs> OnLaunchFromLocalNotification
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<NotificationChangedEventArgs> OnNotificationEnableChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OmoteEventHandler<NotificationChangedEventArgs> OnNotificationCountryChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnFailToRegisterForRemoteNotificationsEventHandler OnFailToRegisterForRemoteNotifications
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void AwakePush(OmotenashiFirebaseOptions options)
	{
	}

	private void Start()
	{
	}

	private void StartPush()
	{
	}

	public void SetSandbox(bool isSandbox)
	{
	}

	public void SetDebugLogEnabled(bool isEnabled)
	{
	}

	public void SendConversion(string appViewerId)
	{
	}

	public void SendSession()
	{
	}

	public void SetRequestEnabled(bool isEnabled)
	{
	}

	public bool IsRequestEnabled()
	{
		return default(bool);
	}

	public void GetNotificationEnabled()
	{
	}

	private void InvokeFromJson<TRaw, TArg>(string json, Func<TRaw, TArg> argsCreator, OmoteEventHandler<TArg> action) where TArg : EventArgs
	{
	}

	public string GetServerUrl()
	{
		return null;
	}

	public string GetSdkVersion()
	{
		return null;
	}

	public void DeleteAppViewerId()
	{
	}

	private void CallbackOnRequestResult(string json)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	[Obsolete]
	public void ScheduleLocalNotification(string messageText, DateTime dateTime, string labelId, LocalNotificationPriority priority, int notificationId)
	{
	}

	[Obsolete]
	public void ScheduleLocalNotification(string messageText, DateTime date, string labelId, LocalNotificationPriority priority, int notificationId, string extraText)
	{
	}

	[Obsolete]
	public void CancelLocalNotification(string labelId)
	{
	}

	[Obsolete]
	public void CancelAllLocalNotification()
	{
	}

	private void CheckToken()
	{
	}

	public void SetNotificationsEnabled(bool enabled)
	{
	}

	public bool IsNotificationsEnabled()
	{
		return default(bool);
	}

	public void UpdateCountry(string country)
	{
	}

	public void RegisterForRemoteNotification()
	{
	}

	public bool IsPlayServicesAvailable()
	{
		return default(bool);
	}

	private void CallbackOnTokenReceived(string token)
	{
	}

	private void CallbackOnReceivedPushNotificationInForeground(string json)
	{
	}

	private void CallbackOnReceivedLocalNotificationInForeground(string json)
	{
	}

	private void CallbackOnLaunchFromPushNotification(string json)
	{
	}

	private void CallbackOnLaunchFromLocalNotification(string json)
	{
	}

	private void CallbackOnNotificationEnableChanged(string json)
	{
	}

	private void CallbackOnNotificationCountryChanged(string json)
	{
	}

	private void CallbackOnFailToRegisterForRemoteNotifications(string errorString)
	{
	}
}
