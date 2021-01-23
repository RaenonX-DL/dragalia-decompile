/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPagePresentGroupListCell : TableViewCell<Gluon.MyPagePresentGroupListCellData>
	{
		// Fields
		[SerializeField]
		private Image cellButtonImage;
		[SerializeField]
		private CanvasGroup cellButtonGroup;
		[SerializeField]
		private UnityEngine.UI.Text groupNameText;
		[SerializeField]
		private UnityEngine.UI.Text quantityText;
		[SerializeField]
		private GameObject linkArrow;
		[SerializeField]
		private GameObject sceneButtonArea;
		[SerializeField]
		private UnityEngine.UI.Text duplicateConfirmText;
		[SerializeField]
		private Button sceneButtonLeft;
		[SerializeField]
		private Button sceneButtonCenter;
		[SerializeField]
		private Button sceneButtonRight;
		[SerializeField]
		private UnityEngine.UI.Text sceneButtonTextLeft;
		[SerializeField]
		private UnityEngine.UI.Text sceneButtonTextCenter;
		[SerializeField]
		private UnityEngine.UI.Text sceneButtonTextRight;
		private MyPagePresentGroupListCellData cellData;
		private GameObject lockObjLeft;
		private GameObject lockObjCenter;
		private GameObject lockObjRight;
	
		// Constructors
		public MyPagePresentGroupListCell();
	
		// Methods
		public override void UpdateContent(MyPagePresentGroupListCellData data);
		public void OnCellButtonPressed();
		public void OnSceneButtonPressed(int index);
		private void SetLockButtonWithStepCheck(Button button, TutorialUIManager.LockButtonType lockType, ref GameObject lockObj);
	}
}
