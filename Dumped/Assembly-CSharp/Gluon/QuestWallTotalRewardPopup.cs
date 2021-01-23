/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallTotalRewardPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image questWallBg;
		[SerializeField]
		private Image[] totallevel;
		[SerializeField]
		private GameObject totalLvRewardNode;
		[SerializeField]
		private GameObject totalLvRewardCell;
		[SerializeField]
		private GameObject totalLvRewardPikupNode;
		[SerializeField]
		private GameObject totalLvRewardPikupCell;
		[SerializeField]
		private UnityEngine.UI.Text[] elementLvText;
		[SerializeField]
		private GameObject nextPickupParent;
		[SerializeField]
		private CommonIcon nextPickupCommonIcon;
		[SerializeField]
		private GameObject nextPickup;
		[SerializeField]
		private GameObject nothingGetTime;
		private int groupId;
	
		// Constructors
		public QuestWallTotalRewardPopup();
	
		// Methods
		public static QuestWallTotalRewardPopup Create(int groupId, UnityAction OnCloseCallback = null);
		public void SetContent();
		private void SetSumImage(int sumLevel);
		private void SetLevelImage(Image image, int level);
		private void OnError(ErrorType errorType, int resultCode);
		private void SetLevel(int[] list);
	}
}
