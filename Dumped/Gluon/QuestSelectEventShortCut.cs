using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectEventShortCut : MonoBehaviour
	{
		[SerializeField]
		private Toggle[] shortCutButtonsToggle;

		public bool SetShortCut(int eventId, bool isSub)
		{
			return default(bool);
		}

		public void SetTutorial(bool isEnabled)
		{
		}
	}
}
