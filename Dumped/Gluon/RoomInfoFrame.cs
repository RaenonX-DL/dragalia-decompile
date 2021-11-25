using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RoomInfoFrame : MonoBehaviour
	{
		[SerializeField]
		private Text questInfoText;

		[SerializeField]
		private GameObject questDifficultyIconRoot;

		[SerializeField]
		private GameObject questElementIconRoot;

		[SerializeField]
		private GameObject questElement2IconRoot;

		private GameObject questDifficultyIconObj;

		public void Initialize(int questId)
		{
		}

		private void SetQuestElement(GameObject iconRoot, int questId, int elementNo)
		{
		}
	}
}
