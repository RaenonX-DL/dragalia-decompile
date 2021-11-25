using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestCellData
	{
		private QuestMainMenuElement _mainMenuElement;

		private QuestEventMenuElement _eventMenuElement;

		private QuestSelectScene.Difficulty _difficulty;

		private QuestMainLocationElement _locationElement;

		public string triggerString;

		public bool isOpen;

		public bool isClear;

		public UnityAction<QuestCellData> pressedCallback;

		public UnityAction<QuestCellData> disableToJoinCallback;

		public QuestUtil.QuestState state;

		public int questId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestType questType
		{
			[CompilerGenerated]
			get
			{
				return default(QuestType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestDataElement questData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestStoryElement storyData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestMainGroupElement mainGroupElement
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestEventGroupElement eventGroupElement
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestWallElement questWallData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public QuestMainMenuElement mainMenuElement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public QuestEventMenuElement eventMenuElement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public QuestSelectScene.Difficulty difficulty
		{
			get
			{
				return default(QuestSelectScene.Difficulty);
			}
			set
			{
			}
		}

		public QuestMainLocationElement locationElement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public QuestCellData(int questId)
		{
		}

		public QuestCellData(int questId, QuestUtil.QuestState questState)
		{
		}

		public QuestCellData(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState questState)
		{
		}

		public QuestCellData(int locationId, QuestSelectScene.Difficulty questDifficulty)
		{
		}

		public QuestCellData(List<QuestEventMenuElement> eventMenuElementList)
		{
		}

		public void Init(int questId, QuestUtil.QuestState questState = QuestUtil.QuestState.None)
		{
		}

		public void InitWall(QuestEventMenuElement eventMenuElement, QuestUtil.QuestState questState = QuestUtil.QuestState.None)
		{
		}

		private void GetQuestState()
		{
		}
	}
}
