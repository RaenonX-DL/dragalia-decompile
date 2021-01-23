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
	public class GuildInfoTableViewCell : TableViewCell<Gluon.GuildInfoCellData>
	{
		// Fields
		[Header]
		[SerializeField]
		public RawImage emblemImage;
		[Header]
		[SerializeField]
		public Image ribbonImage;
		public Sprite[] approvalRibbons;
		public UnityEngine.UI.Text[] approvalTexts;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text[] activityTexts;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text populationText;
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text mottoText;
		[Header]
		[SerializeField]
		public Button button;
		[CompilerGenerated]
		private Action<GuildInfoCellData> _onCellPressed_k__BackingField;
		[CompilerGenerated]
		private Action<GuildInfoCellData> _rejectAction_k__BackingField;
		public const string prefabPath = "Prefabs/OutGame/Guild/GuildInfoTableViewCell";
	
		// Properties
		public Action<GuildInfoCellData> onCellPressed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<GuildInfoCellData> rejectAction { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GuildInfoTableViewCell();
	
		// Methods
		public override void UpdateContent(GuildInfoCellData data);
		public void OnCellPressed();
		public void OnRejectButtonPressed();
	}
}
