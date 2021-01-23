/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SocialPlatforms;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.Android
{
	internal class AndroidJavaConverter
	{
		// Constructors
		public AndroidJavaConverter();
	
		// Methods
		internal static DateTime ToDateTime(long milliseconds);
		internal static int ToLeaderboardVariantTimeSpan(LeaderboardTimeSpan span);
		internal static int ToLeaderboardVariantCollection(LeaderboardCollection collection);
		internal static int ToPageDirection(ScorePageDirection direction);
		internal static Player ToPlayer(AndroidJavaObject player);
		internal static PlayerProfile ToPlayerProfile(AndroidJavaObject player);
		internal static List<string> ToStringList(AndroidJavaObject stringList);
		internal static AndroidJavaObject ToJavaStringList(List<string> list);
		internal static FriendsListVisibilityStatus ToFriendsListVisibilityStatus(int playerListVisibility);
		internal static IUserProfile[] playersBufferToArray(AndroidJavaObject playersBuffer);
	}
}
