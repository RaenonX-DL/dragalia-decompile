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
	public class GuildIconTableViewController : TableViewController<Gluon.GuildModel.ProfileIconData>
	{
		// Fields
		[Header]
		[SerializeField]
		public GiftType type;
		public UnityEngine.UI.Text noItemText;
		private float cellWidth;
		private float cellHeight;
	
		// Constructors
		public GuildIconTableViewController();
	
		// Methods
		protected override float GetCellHeightAtIndex(int index);
		protected override float GetCellWidthAtIndex(int index);
		protected override void Start();
		public void UpdateSelectedIconData(ref GuildModel.ProfileIconData selectedIconData);
		protected override TableViewCell<GuildModel.ProfileIconData> CreateCellForIndex(int index);
	}
}
