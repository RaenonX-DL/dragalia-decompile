using UnityEngine;

namespace Gluon
{
	public class EmptyQuestClearUnitPopup : CommonPopup
	{
		private const string prefabPath = "Prefabs/OutGame/QuestPrepare/EmptyQuestClearUnitPopup";

		public GameObject originCell;

		public Transform contentTransform;

		public static EmptyQuestClearUnitPopup Create()
		{
			return null;
		}

		public void InitPopup(EmptyQuestClearUnitData[] datas)
		{
		}
	}
}
