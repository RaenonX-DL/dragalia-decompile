using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class MultiPlaySettings : ScriptableObject
	{
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
	}
}
