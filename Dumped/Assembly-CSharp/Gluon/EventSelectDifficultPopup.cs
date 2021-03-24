/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventSelectDifficultPopup : PopupBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		public RectTransform frameRT;
		[SerializeField]
		public UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text closeButtonText;
		[SerializeField]
		private UnityEngine.UI.Text eventItemCountText;
		[SerializeField]
		private Transform contentTransform;
		[SerializeField]
		private UnityEngine.UI.Text descriptionText;
		[SerializeField]
		private Transform descriptionObj;
		[Header]
		[SerializeField]
		private Transform multiTag;
		[SerializeField]
		private Transform soloTag;
		[Header]
		[SerializeField]
		private Image itemIcon;
		private FlashPlayerManager flashPlayerManager;
		[SerializeField]
		private TabBase questMultiTab;
		private QuestSupportCanvas.PlayType playType;
		private int baseQuestGroupId;
		private List<QuestEventMenuElement> cellDataList;
		private List<QuestCell> questCellList;
	
		// Constructors
		public EventSelectDifficultPopup();
	
		// Methods
		private void Awake();
		protected override void OnDestroy();
		public void SetLSize();
		public void SetContent(List<QuestEventMenuElement> cellDataList);
		private void UpdateContent(List<QuestEventMenuElement> cellData);
		private void SetDescriptionText(QuestEventMenuElement eventMenuElement);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		private void SetBonus(QuestEventMenuElement eventMenuElement);
		public void OpenDefaultTab(int baseQuestGroupId);
		public void OnSelectedTab(int num);
		private void UpdateContentWithTabData();
	}
}
