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
	public class MissionGuidePopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private MissionGuideListController missionGuideListController;
		[SerializeField]
		private MaintenanceButtonController maintenanceCtrl;
	
		// Constructors
		public MissionGuidePopup();
	
		// Methods
		public static MissionGuidePopup Create();
		public void InitPopup();
		public override void OnOkButtonPressed();
		private void GoNowPlayChapter();
		private bool isContentClear(QuestType questType, int contentId);
	}
}
