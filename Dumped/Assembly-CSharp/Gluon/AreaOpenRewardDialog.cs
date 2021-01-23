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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AreaOpenRewardDialog : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text rewardTitleText;
		[SerializeField]
		private GameObject rewardListContent;
		[SerializeField]
		private Image enemyIcon;
		[SerializeField]
		private GameObject rewardLineTemplate;
		[SerializeField]
		private GameObject titleObject;
		[SerializeField]
		private GameObject enemyObject;
		[SerializeField]
		private GameObject afterEventMessageObject;
		private Action onCloseAction;
		private List<GameObject> rewardIconInstances;
		private EventQuestPageBase currentPage;
		private const string enemyIconPath = "Images/Icon/Combat/Enemy/{0:D5}/Icon_Combat_Enemy_{1:D2}";
	
		// Constructors
		public AreaOpenRewardDialog();
	
		// Methods
		private void OnEnable();
		protected override void OnDestroy();
		public void SetCurrentPage(CombatEventLocationElement location, EventQuestPageBase page, bool isAfterEvent = false);
		private void SetupContents(CombatEventLocationElement location, bool isAfterEvent);
		private void TeardownContents();
		public void SetCloseAction(Action action);
		public void OnCloseButton();
		[CompilerGenerated]
		private void _SetupContents_b__14_0();
	}
}
