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
	public class AlbumPictureBookMedalPopup : PopupBase, ICustomMessage
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text popupTitle;
		[SerializeField]
		private AlbumPictureBookMedalController albumPictureBookMedalController;
		[SerializeField]
		private AlbumPictureBookMedalGroupController albumPictureBookMedalListController;
		private UnityAction onGoChallengeMissionSceneCallback;
	
		// Constructors
		public AlbumPictureBookMedalPopup();
	
		// Methods
		public static AlbumPictureBookMedalPopup Create();
		protected void Awake();
		public void SetContent(MedalPopupType type, int charaId = -1);
		public void SetGoChallengeMissionSceneCallback(UnityAction onCallback);
		public void OnMessagReceived(CustomMessageType messageType, object data);
		protected override void OnDestroy();
	}
}
