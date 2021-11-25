using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class OutGameSettings : ScriptableObject
	{
		public const string path = "Settings/OutGameSettings";

		public string scenarioId_TutorialStep_1_1_Start;

		public string scenarioId_TutorialStep_1_1_QuestReleased;
	}
}
