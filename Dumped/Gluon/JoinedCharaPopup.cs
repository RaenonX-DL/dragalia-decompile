using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class JoinedCharaPopup : PopupBase
	{
		public enum JoinedCharaStatus
		{
			TemporaryJoining,
			ReTemporaryJoining,
			GoneAway,
			FormalJoining,
			MemoryJoining
		}

		[SerializeField]
		private Image charaIcon;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text contentText;

		private static Action onCloseAction;

		public JoinedCharaStatus charaStatus
		{
			[CompilerGenerated]
			get
			{
				return default(JoinedCharaStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static JoinedCharaPopup CreateChara(int charaId, string path, Transform parentTransform, JoinedCharaStatus status)
		{
			return null;
		}

		public static JoinedCharaPopup JoinChara(int charaId, Transform parentTransform, Action closeAction)
		{
			return null;
		}

		private static string GetTitleText(JoinedCharaStatus status)
		{
			return null;
		}

		private static string GetContentText(JoinedCharaStatus status, int charaId)
		{
			return null;
		}

		public void OnOrganizeButtonPressed()
		{
		}

		public void OnClosePopUp()
		{
		}
	}
}
