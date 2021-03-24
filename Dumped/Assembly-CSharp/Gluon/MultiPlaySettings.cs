/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class MultiPlaySettings : ScriptableObject
	{
		// Fields
		public const string resourcesPath = "Settings/MultiPlaySettings";
		public const int matchingVersion100900 = 100900;
		public const int conditionPowerUpperRangeRaid = 1000;
		public const int conditionPowerUpperRangeNormal = 500;
		public int matchingVersion;
		public float autoJoinPriorityLowerTimeMax;
		public bool multiPlayLeaveAlone;
		public bool enableNewAbsorptSync;
		public bool enableNewTimeupSync;
		public bool enableSoloPlayOnGuestDisconnection;
		public bool enableDeadSync;
		public bool enableQuestFailedRetry;
	
		// Constructors
		public MultiPlaySettings();
	}
}
