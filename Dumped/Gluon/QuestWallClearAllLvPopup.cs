using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestWallClearAllLvPopup : CommonPopup
	{
		[SerializeField]
		private Image elementImage;

		[SerializeField]
		private Text questName;

		public static QuestWallClearAllLvPopup Create(int wallId, [Optional] UnityAction OnCloseCallback)
		{
			return null;
		}

		public void InitData(int wallId)
		{
		}
	}
}
