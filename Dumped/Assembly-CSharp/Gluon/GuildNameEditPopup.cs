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
	public class GuildNameEditPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject[] nameEditGOs;
		public GameObject[] mottoEditGOs;
		public GameObject[] noticeEditGOs;
		[Header]
		[SerializeField]
		public InputField inputField;
		public UnityEngine.UI.Text countText;
		public RectTransform inputFieldRT;
		public Button okButton;
		public UnityEngine.UI.Text normalizingComment;
		private Action<string> onOK;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildNameEditPopup";
		private GuildModel.GuildOption option;
		private Type type;
		private int textLimit;
		public const int textInputAllowance = 40;
	
		// Nested types
		public enum Type
		{
			Name = 0,
			Motto = 1,
			Notice = 2
		}
	
		// Constructors
		public GuildNameEditPopup();
	
		// Methods
		public static GuildNameEditPopup Create(Type type, GuildModel.GuildOption option, Action<string> onOK);
		private bool IsTextCountNeedNormalize();
		protected override void Start();
		private string GetTrimmedString(string s);
		private int GetTextLength(string s);
		private void SetCountText();
		private void AdjustHeight();
		public void OnOKButtonPressed();
		[CompilerGenerated]
		private void _Start_b__17_0(string inputText);
	}
}
