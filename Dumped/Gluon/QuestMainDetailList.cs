using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestMainDetailList : QuestListBase
	{
		[SerializeField]
		private Transform contentTransfrom;

		public AnimationListOneCol listAnimation;

		[SerializeField]
		private GameObject scrollBarObj;

		[SerializeField]
		private UIAnimationPublisher scrollBarAnimation;

		private List<QuestMainMenuElement> mainDataList;

		private int locationId;

		private QuestSelectScene.Difficulty difficulty;

		public QuestCell mainStoryMissionTargetCell;

		public bool isOpenCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isCloseCompleted
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		private void OnEnable()
		{
		}

		public void SetContent(int locationId, QuestSelectScene.Difficulty difficulty)
		{
		}

		public void LoadData()
		{
		}

		private void CreateList()
		{
		}

		public void StartEnterAnimation()
		{
		}

		private IEnumerator WaitOpenCompletedCoroutine()
		{
			return null;
		}

		public void StartExitAnimation()
		{
		}

		private IEnumerator WaitCloseCompletedCoroutine()
		{
			return null;
		}

		public void ClickCell(int questId)
		{
		}
	}
}
