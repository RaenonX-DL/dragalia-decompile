using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class MonsterInfoBase : MonoBehaviour
	{
		public Text killCount;

		public Text monsterType;

		public Text basicFlavor;

		public Text addFlavor;

		public Text pieceCount;

		public Button previewButton;

		private const int maxKillCount = 99999999;

		public void SetKillCount(int count)
		{
		}

		public void SetMonsterType(string typeName)
		{
		}

		public void SetBasicFlavor(string text)
		{
		}

		public void SetAddFlavor(string text)
		{
		}

		public void SetPieceCount(int nowCount, int maxCount, MonsterDetailStep step)
		{
		}

		public void SetPreviewButton(MonsterDetailStep step, UnityAction action)
		{
		}
	}
}
