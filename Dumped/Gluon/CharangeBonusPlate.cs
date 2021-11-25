using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CharangeBonusPlate : MonoBehaviour
	{
		[SerializeField]
		private Image[] treasureBoxClosedImages;

		[SerializeField]
		private Image[] treasureBoxOpenedImages;

		[SerializeField]
		protected Image completeImage;

		[SerializeField]
		protected Text resetText;

		public void SetBonusInformation(QuestEventMenuElement eventMenuElement)
		{
		}

		private void SetBonusBoxes(int openedCount, int maxCount)
		{
		}
	}
}
