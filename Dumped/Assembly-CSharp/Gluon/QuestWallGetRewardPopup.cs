/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallGetRewardPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text questWallGetRewardLevel;
		[SerializeField]
		private Image questWallGetRewardLogoImage;
		[SerializeField]
		private Image questWallGetRewardTotalLevelImage;
		[SerializeField]
		private GameObject questWallGetRewardNode;
		[SerializeField]
		private GameObject questWallGetRewardCell;
	
		// Constructors
		public QuestWallGetRewardPopup();
	
		// Methods
		public static QuestWallGetRewardPopup Create(int groupId, UnityAction OnCloseCallback = null);
		public void InitContents(int groupId);
		public void SetContents(int groupId);
	}
}
