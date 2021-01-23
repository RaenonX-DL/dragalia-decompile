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
	public class JoinedCharaPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Image charaIcon;
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text contentText;
		[CompilerGenerated]
		private JoinedCharaStatus _charaStatus_k__BackingField;
		private static Action onCloseAction;
	
		// Properties
		public JoinedCharaStatus charaStatus { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum JoinedCharaStatus
		{
			TemporaryJoining = 0,
			ReTemporaryJoining = 1,
			GoneAway = 2,
			FormalJoining = 3
		}
	
		// Constructors
		public JoinedCharaPopup();
		static JoinedCharaPopup();
	
		// Methods
		public static JoinedCharaPopup CreateChara(int charaId, string path, Transform parentTransform, JoinedCharaStatus status);
		public static JoinedCharaPopup JoinChara(int charaId, Transform parentTransform, Action closeAction);
		private static string GetTitleText(JoinedCharaStatus status);
		private static string GetContentText(JoinedCharaStatus status, int charaId);
		public void OnOrganizeButtonPressed();
		public void OnClosePopUp();
	}
}
