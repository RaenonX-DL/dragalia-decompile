/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AndroidPermission
	{
		// Fields
		private const string JAVA_CLASS_NAME_UNITY_PLAYER = "com.unity3d.player.UnityPlayer";
		private const string JAVA_CLASS_NAME_PACKAGE_MANAGER = "android.content.pm.PackageManager";
		private const string JAVA_CLASS_NAME_BUILD_VERSION = "android.os.Build$VERSION";
		private const string JAVA_CLASS_NAME_CONTEXT_COMPAT = "android.support.v4.content.ContextCompat";
		private const string JAVA_CLASS_NAME_ACTIVITY_COMPAT = "android.support.v4.app.ActivityCompat";
		private const string JAVA_METHOD_NAME_CHECK_SELF_PERMISSION = "checkSelfPermission";
		private const string JAVA_METHOD_NAME_REQUEST_PERMISSIONS = "requestPermissions";
		private const string JAVA_PROPERTY_NAME_PERMISSION_GRANTED = "PERMISSION_GRANTED";
		private const string JAVA_PROPERTY_NAME_CURRENT_ACTIVITY = "currentActivity";
		private const string JAVA_PROPERTY_NAME_SDK = "SDK_INTSDK_INT";
		private static int permissionGranted;
		private static bool? isAndroidMOrGreater;
	
		// Constructors
		public AndroidPermission();
		static AndroidPermission();
	
		// Methods
		public static bool HasPermission(UserAuthorization userAuthorization);
		public static void RequestPermission(UserAuthorization userAuthorization);
		public static bool IsAndroidMOrGreater();
		private static AndroidJavaObject GetActivity();
		private static string GetPermissionName(UserAuthorization userAuthorization);
	}
}
