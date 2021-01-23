/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectWheelChapter : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject[] language;
		[SerializeField]
		private GameObject[] numberBase;
		[SerializeField]
		private UnityEngine.UI.Text[] numberColumText;
		[SerializeField]
		private UnityEngine.UI.Text chapter;
		[SerializeField]
		private UnityEngine.UI.Text[] chapterText;
		[SerializeField]
		private GameObject[] numberBaseEn;
		[SerializeField]
		private UnityEngine.UI.Text[] numberColumTextEn;
		[SerializeField]
		private UnityEngine.UI.Text[] chapterTextEn;
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
	
		// Nested types
		public enum QuestStateIconPos
		{
			Left = 0,
			Right = 1
		}
	
		public enum NumberType
		{
			Under10 = 0,
			Under20 = 1,
			Over20 = 2,
			Max = 3
		}
	
		public enum ColumnIndex
		{
			Under10_0 = 0,
			Under20_0 = 1,
			Under20_1 = 2,
			Over20_0 = 3,
			Over20_1 = 4,
			Max = 5
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public int j;
			public QuestSelectWheelChapter __4__this;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _LoadQuestStateIcon_b__0(GameObject prefab);
		}
	
		// Constructors
		public QuestSelectWheelChapter();
	
		// Methods
		private void Start();
		public GameObject[] GetNumberBase();
		public void SetNumber(int number, QuestSelectWheel wheel);
		private void LoadQuestStateIcon();
		public void SetQuestStateIcon(QuestSelectScene.Difficulty difficulty, int groupId);
		public void SetQuestStateIconPos(QuestStateIconPos pos);
		public void SetDifficultyFrame(QuestSelectScene.Difficulty difficulty);
		public void SetQuestStateIconColor(Color iconColor);
		public void SetCenterFrame(bool enable);
		public void OnClickMainQuestChapter();
		public void SetStateActive(bool isEnable);
		public void SetChapter(bool isEnable);
		public void SetChapterColor(Color color);
	}
}
