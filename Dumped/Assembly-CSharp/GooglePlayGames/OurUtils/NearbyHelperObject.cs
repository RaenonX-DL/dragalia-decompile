/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GooglePlayGames.BasicApi.Nearby;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.OurUtils
{
	public class NearbyHelperObject : MonoBehaviour
	{
		// Fields
		private static NearbyHelperObject instance;
		private static double mAdvertisingRemaining;
		private static double mDiscoveryRemaining;
		private static INearbyConnectionClient mClient;
	
		// Constructors
		public NearbyHelperObject();
		static NearbyHelperObject();
	
		// Methods
		public static void CreateObject(INearbyConnectionClient client);
		private static double ToSeconds(TimeSpan? span);
		public static void StartAdvertisingTimer(TimeSpan? span);
		public static void StartDiscoveryTimer(TimeSpan? span);
		public void Awake();
		public void OnDisable();
		public void Update();
	}
}
