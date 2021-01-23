/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectWheelElement : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Canvas parentCanvas;
		[SerializeField]
		public UnityEngine.UI.Text uiAchievementLevelText;
		[SerializeField]
		public CanvasGroup uiAchievementLevelCanvasGroup;
		[SerializeField]
		private CanvasGroup diffcultFrameCanvasGroup;
		[SerializeField]
		public Image mainImage;
		[SerializeField]
		private RawImage notOpenElement;
		[SerializeField]
		private UnityEngine.UI.Text notOpenElementText;
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
		private UnityEngine.UI.Text[] alphaTargetTexts;
	
		// Nested types
		public enum WheelChapterSize
		{
			Front = 0,
			Middle = 1,
			Back = 2,
			Max = 3
		}
	
		// Constructors
		public QuestSelectWheelElement();
	
		// Methods
		private void Start();
		public void SetQuestStateIcon(QuestSelectScene.Difficulty difficulty, int groupId);
		public void SetQuestStateIconPos(QuestSelectWheelChapter.QuestStateIconPos pos);
		public void SetWheelElementAlpha(float alpha);
		public void SetDifficultyFrame(QuestSelectScene.Difficulty difficulty);
		public Tweener FadeDifficultyFrame(float endValue, float duration);
		public void FadeDifficultyFrameAlpha(float value);
		public void SetBaseRot(float rot);
		public float GetBaseRot();
		public float GetWheelRot();
		public QSChapterElement GetChapterElement();
		public void SetChapterElement(QSChapterElement a_chapterElement);
		public void SetChapter(int a_chapterNumber, QuestMainGroupElement a_questGroup);
		public int GetChapterNumber();
		public QuestMainGroupElement GetQuestGroup();
		public Vector3 SetWheelRot(float rot, int index, int maxChapter);
		public void SetSize(WheelChapterSize size);
		private void SetAchievementScale(WheelChapterSize size);
		public void SetBG(Sprite spr);
		public void SetMaterialColorEnlighten(WheelChapterSize size);
		public void SetMaterial(Material mat);
		public void SetMaterialColor(int i);
		public void DisplayAchievementLevel();
		public Tweener FadeUiAchievementLevel(float endValue, float duration);
		public void UiAchievementLevelAlpha(float value);
		public void SetParentWidth(float width);
		public void SetRotationActive(bool isEnable);
	}
}
