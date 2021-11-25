using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestElementIcon : MonoBehaviour
	{
		[SerializeField]
		private Image[] elementImageArray;

		[SerializeField]
		private Color iconGrayColor;

		private int activeIndex;

		public void SetupQuestElementIcon(int questId, bool isParty2 = false, bool isGray = false)
		{
		}

		public void SetGradientShader(QuestListCellShaderExchanger shaderExchanger)
		{
		}
	}
}
