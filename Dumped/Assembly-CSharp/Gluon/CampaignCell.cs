/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CampaignCell : TableViewCell<Gluon.CampaignCellData>
	{
		// Fields
		public Image icon;
		public UnityEngine.UI.Text description;
		public UnityEngine.UI.Text remainDate;
		private CampaignDataWrapper data;
	
		// Constructors
		public CampaignCell();
	
		// Methods
		private void Start();
		public override void UpdateContent(CampaignCellData cellData);
		public void InitParam(CampaignDataWrapper data);
		public void OnPressed();
	}
}
