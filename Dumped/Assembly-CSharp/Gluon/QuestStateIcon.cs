/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestStateIcon : MonoBehaviour
	{
		// Fields
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
	
		// Nested types
		public enum StateIcon
		{
			none = 0,
			newIcon = 1,
			completeIcon = 2,
			clear = 3
		}
	
		// Constructors
		public QuestStateIcon();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public QuestUtil.QuestState SetupQuestStateIcon(QuestSelectScene.Difficulty difficulty, bool isForceInit, bool isCentering, int groupId = 0, int locationId = 0, int questId = 0);
		public static QuestUtil.QuestState GetQuestState(ref List<QuestMainMenuElement> qmmeList, int groupId, int locationId, int questId, QuestSelectScene.Difficulty difficulty);
		private void SetDisp(bool dispCompleted, bool dispCleared, bool dispNew);
		public void SetEventQuestStateIcon(QuestUtil.QuestState state);
		public void SetQuestStateIconColor(Color iconColor);
		public void SetStateIcon(StateIcon state);
	}
}
