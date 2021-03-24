/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class CampaignListController : TableViewController<Gluon.CampaignCellData>
	{
		// Fields
		public const float cellHeight = 150f;
	
		// Constructors
		public CampaignListController();
	
		// Methods
		protected override void Awake();
		protected override TableViewCell<CampaignCellData> CreateCellForIndex(int index);
		public void LoadData(List<CampaignCellData> cellList);
		public void ReloadData(List<CampaignCellData> cellList);
		protected override float GetCellHeightAtIndex(int index);
	}
}
