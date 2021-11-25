using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectWheelElement : MonoBehaviour
	{
		public enum WheelChapterSize
		{
			Front,
			Middle,
			Back,
			Max
		}

		[SerializeField]
		public Canvas parentCanvas;

		[SerializeField]
		public Text uiAchievementLevelText;

		[SerializeField]
		public CanvasGroup uiAchievementLevelCanvasGroup;

		[SerializeField]
		private CanvasGroup diffcultFrameCanvasGroup;

		[SerializeField]
		public Image mainImage;

		[SerializeField]
		private RawImage notOpenElement;

		[SerializeField]
		private Text notOpenElementText;

		[SerializeField]
		private Image notOpenElementRockIcon;

		[SerializeField]
		private Transform achievement;

		private const float frontAchievementLevelScale = 1f;

		private const float middleAchievementLevelScale = 0.8f;

		private const float backAchievementLevelScale = 0.6f;

		private const int achievementPercent = 100;

		public Image[] uiBGImage;

		public Image blackTransparent;

		public float[] uiColorEnlighten;

		public QuestSelectWheel parentWheelObj;

		private float baseRot;

		private float wheelRot;

		private float wheelWidth;

		private int chapterNumber;

		private QuestMainGroupElement questGroup;

		public QuestSelectWheelChapter wheelChapterObj;

		public Image wheelChapterImages;

		private QSChapterElement chapterElement;

		private Image[] alphaTargetImages;

		private Text[] alphaTargetTexts;

		private void Start()
		{
		}

		public void SetQuestStateIcon(QuestSelectScene.Difficulty difficulty, int groupId)
		{
		}

		public void SetQuestStateIconPos(QuestSelectWheelChapter.QuestStateIconPos pos)
		{
		}

		public void SetWheelElementAlpha(float alpha)
		{
		}

		public void SetDifficultyFrame(QuestSelectScene.Difficulty difficulty)
		{
		}

		public Tweener FadeDifficultyFrame(float endValue, float duration)
		{
			return null;
		}

		public void FadeDifficultyFrameAlpha(float value)
		{
		}

		public void SetBaseRot(float rot)
		{
		}

		public float GetBaseRot()
		{
			return default(float);
		}

		public float GetWheelRot()
		{
			return default(float);
		}

		public QSChapterElement GetChapterElement()
		{
			return null;
		}

		public void SetChapterElement(QSChapterElement a_chapterElement)
		{
		}

		public void SetChapter(int a_chapterNumber, QuestMainGroupElement a_questGroup)
		{
		}

		public int GetChapterNumber()
		{
			return default(int);
		}

		public QuestMainGroupElement GetQuestGroup()
		{
			return null;
		}

		public Vector3 SetWheelRot(float rot, int index, int maxChapter)
		{
			return default(Vector3);
		}

		public void SetSize(WheelChapterSize size)
		{
		}

		private void SetAchievementScale(WheelChapterSize size)
		{
		}

		public void SetBG(Sprite spr)
		{
		}

		public void SetMaterialColorEnlighten(WheelChapterSize size)
		{
		}

		public void SetMaterial(Material mat)
		{
		}

		public void SetMaterialColor(int i)
		{
		}

		public void DisplayAchievementLevel()
		{
		}

		public Tweener FadeUiAchievementLevel(float endValue, float duration)
		{
			return null;
		}

		public void UiAchievementLevelAlpha(float value)
		{
		}

		public void SetParentWidth(float width)
		{
		}

		public void SetRotationActive(bool isEnable)
		{
		}
	}
}
