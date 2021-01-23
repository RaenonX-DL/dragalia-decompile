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
	public class GuildEasyReportButton : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public GuildReportConfirmPopup.ReportAbuseType type;
		public Button onClickEventButton;
		[CompilerGenerated]
		private int _targetGuildId_k__BackingField;
		private PointerEventHandler eventHandler;
		private UnityEngine.UI.Text text;
		private bool isDeletedContent;
	
		// Properties
		public int targetGuildId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GuildEasyReportButton();
	
		// Methods
		public static GuildEasyReportButton BindToText(UnityEngine.UI.Text text, GuildReportConfirmPopup.ReportAbuseType type, int guildId, bool isDeletedContent, Button onClickEventButton = null);
		private void RefreshComponent();
		private void Start();
		public void OnLongTouched();
		[CompilerGenerated]
		private void _RefreshComponent_b__10_0();
	}
}
