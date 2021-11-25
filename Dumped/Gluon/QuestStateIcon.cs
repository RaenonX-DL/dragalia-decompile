using System.Collections.Generic;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestStateIcon : MonoBehaviour
	{
		public enum StateIcon
		{
			none,
			newIcon,
			completeIcon,
			clear
		}

		[SerializeField]
		private Image newMarkImage;

		[SerializeField]
		private Image clearMarkImage;

		[SerializeField]
		private Image completeMarkImage;

		[SerializeField]
		private Vector2 blinkingToFrom;

		[SerializeField]
		private float blinkingDuring;

		[SerializeField]
		private Ease blinkingEasing;

		private bool isInit;

		private bool isInitMaterial;

		private List<QuestMainMenuElement> qmmeList;

		private Sequence blinkSeq;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public QuestUtil.QuestState SetupQuestStateIcon(QuestSelectScene.Difficulty difficulty, bool isForceInit, bool isCentering, int groupId = 0, int locationId = 0, int questId = 0)
		{
			return default(QuestUtil.QuestState);
		}

		public static QuestUtil.QuestState GetQuestState(ref List<QuestMainMenuElement> qmmeList, int groupId, int locationId, int questId, QuestSelectScene.Difficulty difficulty)
		{
			return default(QuestUtil.QuestState);
		}

		private void SetDisp(bool dispCompleted, bool dispCleared, bool dispNew)
		{
		}

		public void SetEventQuestStateIcon(QuestUtil.QuestState state)
		{
		}

		public void SetQuestStateIconColor(Color iconColor)
		{
		}

		public void SetStateIcon(StateIcon state)
		{
		}
	}
}
