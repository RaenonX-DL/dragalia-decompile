using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectWheelChapter : MonoBehaviour
	{
		public enum QuestStateIconPos
		{
			Left,
			Right
		}

		public enum NumberType
		{
			Under10,
			Under20,
			Over20,
			Max
		}

		public enum ColumnIndex
		{
			Under10_0,
			Under20_0,
			Under20_1,
			Over20_0,
			Over20_1,
			Max
		}

		[SerializeField]
		private GameObject[] language;

		[SerializeField]
		private GameObject[] numberBase;

		[SerializeField]
		private Text[] numberColumText;

		[SerializeField]
		private Text chapter;

		[SerializeField]
		private Text[] chapterText;

		[SerializeField]
		private GameObject[] numberBaseEn;

		[SerializeField]
		private Text[] numberColumTextEn;

		[SerializeField]
		private Text[] chapterTextEn;

		[SerializeField]
		private GameObject[] questStateIconParents;

		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Sprite[] difficultySprites;

		[SerializeField]
		private Image[] centerFrame;

		private List<QuestStateIcon> questStateIconList;

		private QuestSelectWheel questSelectWheel;

		private QuestSelectScene.Difficulty difficulty;

		private int groupId;

		private void Start()
		{
		}

		public GameObject[] GetNumberBase()
		{
			return null;
		}

		public void SetNumber(int number, QuestSelectWheel wheel)
		{
		}

		private void LoadQuestStateIcon()
		{
		}

		public void SetQuestStateIcon(QuestSelectScene.Difficulty difficulty, int groupId)
		{
		}

		public void SetQuestStateIconPos(QuestStateIconPos pos)
		{
		}

		public void SetDifficultyFrame(QuestSelectScene.Difficulty difficulty)
		{
		}

		public void SetQuestStateIconColor(Color iconColor)
		{
		}

		public void SetCenterFrame(bool enable)
		{
		}

		public void OnClickMainQuestChapter()
		{
		}

		public void SetStateActive(bool isEnable)
		{
		}

		public void SetChapter(bool isEnable)
		{
		}

		public void SetChapterColor(Color color)
		{
		}
	}
}
