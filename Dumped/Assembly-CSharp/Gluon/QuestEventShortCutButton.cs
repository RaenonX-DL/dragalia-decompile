/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventShortCutButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private QuestEventShortCutType shortCutType;
		private const int firstReleaseQuest = 1000202;
		private const int secondReleaseQuest = 1000311;
		private const int thirdReleaseQuest = 1000607;
		private const int moneyQuestGroupId = 20206;
		private const int expQuestGroupId = 20101;
		private const int remainsQuestGroupId = 20201;
		private const int dragonQuestGroupId = 20301;
		private const int empireQuestGroupId = 21101;
		private const int expQuestEventId = 20101;
		private const int moneyQuestEventId = 20206;
		private const int remainsQuestEventId = 20200;
		private const int dragonQuestEventId = 20300;
		private const int empireQuestEventId = 21100;
	
		// Nested types
		public enum QuestEventShortCutType
		{
			ExpQuest = 0,
			MoneyQuest = 1,
			RemainsQuest = 2,
			DragonQuest = 3,
			EmpireQuest = 4
		}
	
		// Constructors
		public QuestEventShortCutButton();
	
		// Methods
		private void Awake();
		public void OnShortCutButton();
		public static QuestEventShortCutType GetShortCutType(int eventId);
		public void SetEnabled(bool isEnabled);
	}
}
