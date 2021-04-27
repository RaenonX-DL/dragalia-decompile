/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustUtils
	{
		// Fields
		public static string KeyAdid;
		public static string KeyMessage;
		public static string KeyNetwork;
		public static string KeyAdgroup;
		public static string KeyCampaign;
		public static string KeyCreative;
		public static string KeyWillRetry;
		public static string KeyTimestamp;
		public static string KeyCallbackId;
		public static string KeyEventToken;
		public static string KeyClickLabel;
		public static string KeyTrackerName;
		public static string KeyTrackerToken;
		public static string KeyJsonResponse;
		public static string KeyCostType;
		public static string KeyCostAmount;
		public static string KeyCostCurrency;
		public static string KeyTestOptionsBaseUrl;
		public static string KeyTestOptionsGdprUrl;
		public static string KeyTestOptionsSubscriptionUrl;
		public static string KeyTestOptionsExtraPath;
		public static string KeyTestOptionsBasePath;
		public static string KeyTestOptionsGdprPath;
		public static string KeyTestOptionsDeleteState;
		public static string KeyTestOptionsUseTestConnectionOptions;
		public static string KeyTestOptionsTimerIntervalInMilliseconds;
		public static string KeyTestOptionsTimerStartInMilliseconds;
		public static string KeyTestOptionsSessionIntervalInMilliseconds;
		public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
		public static string KeyTestOptionsTeardown;
		public static string KeyTestOptionsNoBackoffWait;
		public static string KeyTestOptionsiAdFrameworkEnabled;
		public static string KeyTestOptionsAdServicesFrameworkEnabled;
	
		// Constructors
		public AdjustUtils();
		static AdjustUtils();
	
		// Methods
		public static int ConvertLogLevel(AdjustLogLevel? logLevel);
		public static int ConvertBool(bool? value);
		public static double ConvertDouble(double? value);
		public static long ConvertLong(long? value);
		public static string ConvertListToJson(List<string> list);
		public static string GetJsonResponseCompact(Dictionary<string, object> dictionary);
		public static string GetJsonString(JSONNode node, string key);
		public static void WriteJsonResponseDictionary(JSONClass jsonObject, Dictionary<string, object> output);
		public static string TryGetValue(Dictionary<string, string> dictionary, string key);
		public static AndroidJavaObject TestOptionsMap2AndroidJavaObject(Dictionary<string, string> testOptionsMap, AndroidJavaObject ajoCurrentActivity);
	}
}
