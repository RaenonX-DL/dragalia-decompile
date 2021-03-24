/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayerProfile : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text nowPlayerName;
		public UnityEngine.UI.Text playerIDText;
		public UnityEngine.UI.Text rubyText;
		public UnityEngine.UI.Text anotherNameText;
		public Button jumpAnotherNameButton;
		public Button editPlayerNameButton;
		public Button idCopyButton;
		public Image anotherNameIcon;
		[Header]
		public UnityEngine.UI.Text anotherNameTitle;
		public UnityEngine.UI.Text playerNameTitle;
		public UnityEngine.UI.Text playerIDTitle;
		public UnityEngine.UI.Text anotherNameChangeText;
		public UnityEngine.UI.Text playerNameChangeText;
		public UnityEngine.UI.Text playerIDCopyText;
		[Header]
		[SerializeField]
		public GameObject guildGO;
		public GameObject noGuildGO;
		public UnityEngine.UI.Text guildNameText;
		public RawImage guildEmblem;
	
		// Constructors
		public PlayerProfile();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetupAnotherName(int nameId);
	}
}
