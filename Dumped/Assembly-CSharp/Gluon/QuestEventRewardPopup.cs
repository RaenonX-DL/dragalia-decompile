/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventRewardPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/EventQuest/TimeAttack/QuestEventRewardPopup";
		[SerializeField]
		private UnityEngine.UI.Text popupTitleText;
		[SerializeField]
		private Image logoImage;
		[SerializeField]
		private QuestEventRewardCtrl rewardCtrl;
		[SerializeField]
		private GameObject rankingInfo;
		[SerializeField]
		private UnityEngine.UI.Text tierRankingText;
		[SerializeField]
		private UnityEngine.UI.Text myBestTimeSoloText;
	
		// Constructors
		public QuestEventRewardPopup();
	
		// Methods
		public static QuestEventRewardPopup Create(QuestEventElement qee);
		public void UpdateReceiveButtonInformation();
		public void SetContent(QuestEventElement qee);
	}
}
