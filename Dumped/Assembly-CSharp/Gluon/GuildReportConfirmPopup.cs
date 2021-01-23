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
	public class GuildReportConfirmPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text contentText;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildReportConfirmPopup";
		private Action<bool> onAnyActionDone;
		private ReportData reportData;
	
		// Nested types
		public enum ReportAbuseType
		{
			Chat = 0,
			Notice = 1,
			Motto = 2,
			GuildName = 3
		}
	
		public struct ReportData
		{
			// Fields
			public ReportAbuseType type;
			public int guildId;
			public ulong chatId;
			public string content;
	
			// Constructors
			public ReportData(ReportAbuseType type, int guildId, ulong chatId, string content);
		}
	
		// Constructors
		public GuildReportConfirmPopup();
	
		// Methods
		public static GuildReportConfirmPopup Create(ReportData reportData, Action<bool> onAnyActionDone);
		protected override void Start();
		public void OnReportButtonPressed();
		public void OnCloseButtonPressed();
	}
}
