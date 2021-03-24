/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRFriendApplyCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Transform movingPart;
		public CommonFriendListCell cell;
		public GameObject alreadyFriendLabel;
		public Button applyButton;
		private QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info;
	
		// Constructors
		public QRFriendApplyCell();
	
		// Methods
		public static QRFriendApplyCell Create(QuestResultModel.FriendApplyModel.SingleFriendApplyInfo info, Transform parent, GameObject originCell);
		private void Start();
		public void OnApplyPressed();
		private void OnClose(bool onClose);
		public void SetUnitDetailModelOnCreated(UnityAction onCreated);
		public void SetUnitDetailModelBackButtonOnClick(UnityAction onCreated);
	}
}
