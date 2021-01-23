/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestTreasureBoxRewardPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text uiTitle;
		public UnityEngine.UI.Text uiSuccessText;
		public UnityEngine.UI.Text uiConditionTitle;
		public UnityEngine.UI.Text uiConditionText;
		public Image uiConditionTextUnderline;
		public RectTransform uiContents;
		[SerializeField]
		public GameObject uiCell;
		[SerializeField]
		private GameObject possessionRoot;
		[SerializeField]
		private Image rewardTypeIcon;
		[SerializeField]
		private UnityEngine.UI.Text posessionText;
		[SerializeField]
		private UnityEngine.UI.Text curPosessionNum;
		[SerializeField]
		private UnityEngine.UI.Text newPosessionNum;
		private readonly int underlineAddtionalLength;
		private UiImageExchanger iconExchanger;
	
		// Nested types
		private enum RewardIconType
		{
			Dragon = 0,
			Weapon = 1,
			Amulet = 2
		}
	
		// Constructors
		public QuestTreasureBoxRewardPopup();
	
		// Methods
		public static QuestTreasureBoxRewardPopup Create(QuestSelectScene qss, QuestMainLocationElement qmle, int chapterNumber, QuestSelectScene.Difficulty difficulty, bool isEnable, UnityAction onCloseCallback, bool showBlackLayer = true);
		private void ReflectParam(QuestMainLocationElement qmle, int chapterNumber, QuestSelectScene.Difficulty difficulty, bool isEnable);
		private void SetDisp(Transform trans, bool value);
	}
}
