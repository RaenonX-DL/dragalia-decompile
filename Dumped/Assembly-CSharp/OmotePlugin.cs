/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class OmotePlugin : MonoBehaviour
{
	// Fields
	private AndroidJavaObject mOmotePluginBaseBridge;
	[SerializeField]
	private OmotenashiFirebaseOptions omotenashiFirebaseOptions;
	[SerializeField]
	private bool IsAutomatic;
	[CompilerGenerated]
	private OnNotifyEnabledReceivedEventHandler OnNotificationRecetived;
	[CompilerGenerated]
	private OmoteEventHandler<RequestResultEventArgs> OnRequestResult;
	internal static AndroidJavaObject mOmotePluginPushBridge;
	private static bool mStartPushCalled;
	public string country;
	[CompilerGenerated]
	private OnRegistrationTokenReceivedEventHandler OnRegistrationTokenReceived;
	[CompilerGenerated]
	private OmoteEventHandler<PushNotificationEventArgs> OnReceivedPushNotification;
	[CompilerGenerated]
	private OmoteEventHandler<LocalNotificationEventArgs> OnReceivedLocalNotification;
	[CompilerGenerated]
	private OmoteEventHandler<PushNotificationEventArgs> OnLaunchFromPushNotification;
	[CompilerGenerated]
	private OmoteEventHandler<LocalNotificationEventArgs> OnLaunchFromLocalNotification;
	[CompilerGenerated]
	private OmoteEventHandler<NotificationChangedEventArgs> OnNotificationEnableChanged;
	[CompilerGenerated]
	private OmoteEventHandler<NotificationChangedEventArgs> OnNotificationCountryChanged;
	[CompilerGenerated]
	private OnFailToRegisterForRemoteNotificationsEventHandler OnFailToRegisterForRemoteNotifications;

	// Events
	public event OnNotifyEnabledReceivedEventHandler OnNotificationRecetived {
		add;
		remove;
	}
	public event OmoteEventHandler<RequestResultEventArgs> OnRequestResult {
		add;
		remove;
	}
	public event OnRegistrationTokenReceivedEventHandler OnRegistrationTokenReceived {
		add;
		remove;
	}
	public event OmoteEventHandler<PushNotificationEventArgs> OnReceivedPushNotification {
		add;
		remove;
	}
	public event OmoteEventHandler<LocalNotificationEventArgs> OnReceivedLocalNotification {
		add;
		remove;
	}
	public event OmoteEventHandler<PushNotificationEventArgs> OnLaunchFromPushNotification {
		add;
		remove;
	}
	public event OmoteEventHandler<LocalNotificationEventArgs> OnLaunchFromLocalNotification {
		add;
		remove;
	}
	public event OmoteEventHandler<NotificationChangedEventArgs> OnNotificationEnableChanged {
		add;
		remove;
	}
	public event OmoteEventHandler<NotificationChangedEventArgs> OnNotificationCountryChanged {
		add;
		remove;
	}
	public event OnFailToRegisterForRemoteNotificationsEventHandler OnFailToRegisterForRemoteNotifications {
		add;
		remove;
	}

	// Nested types
	public delegate void OnNotifyEnabledReceivedEventHandler(bool enabled);

	[Serializable]
	private class OmotenashiFirebaseOptions
	{
		// Fields
		public string ApiKey;
		public string ProjectId;
		public string ApplicationId;
		public string SenderId;

		// Constructors
		public OmotenashiFirebaseOptions();
	}

	public delegate void OmoteEventHandler<in TEventArgs>(object sender, TEventArgs e);

	public class RequestResultEventArgs : EventArgs
	{
		// Fields
		[CompilerGenerated]
		private int _Type_k__BackingField;
		[CompilerGenerated]
		private int _Result_k__BackingField;
		[CompilerGenerated]
		private string _Body_k__BackingField;
		[CompilerGenerated]
		private string _EndPoint_k__BackingField;
		[CompilerGenerated]
		private int _StatusCode_k__BackingField;
		[CompilerGenerated]
		private string _Reason_k__BackingField;

		// Properties
		public int Type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int Result { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Body { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string EndPoint { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int StatusCode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Reason { [CompilerGenerated] get; [CompilerGenerated] private set; }

		// Nested types
		internal class RawData
		{
			// Fields
			public int type;
			public int result;
			public string body;
			public string endpoint;
			public int statusCode;
			public string reason;

			// Constructors
			public RawData();
		}

		// Constructors
		internal RequestResultEventArgs(RawData data);
	}

	public class LocalNotification
	{
		// Fields
		private static readonly DateTime UnixEpoch;
		[CompilerGenerated]
		private string _Message_k__BackingField;
		[CompilerGenerated]
		private DateTime _When_k__BackingField;
		[CompilerGenerated]
		private string _LabelId_k__BackingField;
		[CompilerGenerated]
		private LocalNotificationPriority _Priority_k__BackingField;
		[CompilerGenerated]
		private int _NotificationId_k__BackingField;
		[CompilerGenerated]
		private string _Title_k__BackingField;
		[CompilerGenerated]
		private string _ExtraText_k__BackingField;
		[CompilerGenerated]
		private string _ImagePath_k__BackingField;

		// Properties
		public string Message { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DateTime When { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string LabelId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public LocalNotificationPriority Priority { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int NotificationId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string Title { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string ExtraText { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string ImagePath { [CompilerGenerated] get; [CompilerGenerated] set; }

		// Constructors
		public LocalNotification(string message, DateTime when, string labelId);
		static LocalNotification();

		// Methods
		public void Schedule();
		public void Cancel();
		public static void Cancel(string labelId);
		public static void CancelAll();
	}

	public class RegistrationTokenEventArgs : EventArgs
	{
		// Fields
		[CompilerGenerated]
		private string _RegistrationToken_k__BackingField;

		// Properties
		public string RegistrationToken { [CompilerGenerated] get; [CompilerGenerated] set; }

		// Constructors
		public RegistrationTokenEventArgs();
	}

	public class PushNotificationEventArgs : EventArgs
	{
		// Fields
		[CompilerGenerated]
		private string _Id_k__BackingField;
		[CompilerGenerated]
		private string _Message_k__BackingField;
		[CompilerGenerated]
		private string _Extra_k__BackingField;

		// Properties
		public string Id { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Message { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Extra { [CompilerGenerated] get; [CompilerGenerated] private set; }

		// Nested types
		internal class RawData
		{
			// Fields
			public string id;
			public string message;
			public string extra;

			// Constructors
			public RawData();
		}

		// Constructors
		internal PushNotificationEventArgs(RawData data);

		// Methods
		public override string ToString();
	}

	public class LocalNotificationEventArgs : EventArgs
	{
		// Fields
		[CompilerGenerated]
		private string _ScheduleId_k__BackingField;
		[CompilerGenerated]
		private string _LabelId_k__BackingField;
		[CompilerGenerated]
		private DateTime _ScheduledAt_k__BackingField;
		[CompilerGenerated]
		private string _MessageText_k__BackingField;
		[CompilerGenerated]
		private string _ExtraText_k__BackingField;

		// Properties
		public string ScheduleId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string LabelId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public DateTime ScheduledAt { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string MessageText { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string ExtraText { [CompilerGenerated] get; [CompilerGenerated] private set; }

		// Nested types
		internal class RawData
		{
			// Fields
			public string scheduleId;
			public string label;
			public string scheduled;
			public string message;
			public string extra;

			// Constructors
			public RawData();
		}

		// Constructors
		internal LocalNotificationEventArgs(RawData data);

		// Methods
		public override string ToString();
	}

	public class NotificationChangedEventArgs : EventArgs
	{
		// Fields
		[CompilerGenerated]
		private bool _Result_k__BackingField;

		// Properties
		public bool Result { [CompilerGenerated] get; [CompilerGenerated] private set; }

		// Nested types
		internal class RawData
		{
			// Fields
			public bool result;

			// Constructors
			public RawData();
		}

		// Constructors
		internal NotificationChangedEventArgs(RawData data);

		// Methods
		public override string ToString();
	}

	public delegate void OnRegistrationTokenReceivedEventHandler(object sender, RegistrationTokenEventArgs e);

	public delegate void OnFailToRegisterForRemoteNotificationsEventHandler(object sender, string e);

	[Serializable]
	[CompilerGenerated]
	private sealed class __c
	{
		// Fields
		public static readonly __c __9;
		public static Func<RequestResultEventArgs.RawData, RequestResultEventArgs> __9__28_0;
		public static Func<PushNotificationEventArgs.RawData, PushNotificationEventArgs> __9__75_0;
		public static Func<LocalNotificationEventArgs.RawData, LocalNotificationEventArgs> __9__76_0;
		public static Func<PushNotificationEventArgs.RawData, PushNotificationEventArgs> __9__77_0;
		public static Func<LocalNotificationEventArgs.RawData, LocalNotificationEventArgs> __9__78_0;
		public static Func<NotificationChangedEventArgs.RawData, NotificationChangedEventArgs> __9__79_0;
		public static Func<NotificationChangedEventArgs.RawData, NotificationChangedEventArgs> __9__80_0;

		// Constructors
		static __c();
		public __c();

		// Methods
		internal RequestResultEventArgs _CallbackOnRequestResult_b__28_0(RequestResultEventArgs.RawData raw);
		internal PushNotificationEventArgs _CallbackOnReceivedPushNotificationInForeground_b__75_0(PushNotificationEventArgs.RawData raw);
		internal LocalNotificationEventArgs _CallbackOnReceivedLocalNotificationInForeground_b__76_0(LocalNotificationEventArgs.RawData raw);
		internal PushNotificationEventArgs _CallbackOnLaunchFromPushNotification_b__77_0(PushNotificationEventArgs.RawData raw);
		internal LocalNotificationEventArgs _CallbackOnLaunchFromLocalNotification_b__78_0(LocalNotificationEventArgs.RawData raw);
		internal NotificationChangedEventArgs _CallbackOnNotificationEnableChanged_b__79_0(NotificationChangedEventArgs.RawData raw);
		internal NotificationChangedEventArgs _CallbackOnNotificationCountryChanged_b__80_0(NotificationChangedEventArgs.RawData raw);
	}

	// Constructors
	public OmotePlugin();
	static OmotePlugin();

	// Methods
	private void Awake();
	private void AwakePush(OmotenashiFirebaseOptions options);
	private void Start();
	private void StartPush();
	public void SetSandbox(bool isSandbox);
	public void SetDebugLogEnabled(bool isEnabled);
	public void SendConversion(string appViewerId);
	public void SendSession();
	public void SetRequestEnabled(bool isEnabled);
	public bool IsRequestEnabled();
	public void GetNotificationEnabled();
	private void InvokeFromJson<TArg, TRaw>(string json, Func<TRaw, TArg> argsCreator, OmoteEventHandler<TArg> action)
		where TArg : EventArgs;
	public string GetServerUrl();
	public string GetSdkVersion();
	public void DeleteAppViewerId();
	private void CallbackOnRequestResult(string json);
	private void OnApplicationPause(bool pause);
	[Obsolete]
	public void ScheduleLocalNotification(string messageText, DateTime dateTime, string labelId, LocalNotificationPriority priority, int notificationId);
	[Obsolete]
	public void ScheduleLocalNotification(string messageText, DateTime date, string labelId, LocalNotificationPriority priority, int notificationId, string extraText);
	[Obsolete]
	public void CancelLocalNotification(string labelId);
	[Obsolete]
	public void CancelAllLocalNotification();
	private void CheckToken();
	public void SetNotificationsEnabled(bool enabled);
	public bool IsNotificationsEnabled();
	public void UpdateCountry(string country);
	public void RegisterForRemoteNotification();
	public bool IsPlayServicesAvailable();
	private void CallbackOnTokenReceived(string token);
	private void CallbackOnReceivedPushNotificationInForeground(string json);
	private void CallbackOnReceivedLocalNotificationInForeground(string json);
	private void CallbackOnLaunchFromPushNotification(string json);
	private void CallbackOnLaunchFromLocalNotification(string json);
	private void CallbackOnNotificationEnableChanged(string json);
	private void CallbackOnNotificationCountryChanged(string json);
	private void CallbackOnFailToRegisterForRemoteNotifications(string errorString);
}

