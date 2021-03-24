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
	public class MissionGuideListCell : TableViewCell<Gluon.MissionGuideListCellData>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text desText;
		[SerializeField]
		private GameObject clearObj;
	
		// Constructors
		public MissionGuideListCell();
	
		// Methods
		public override void UpdateContent(MissionGuideListCellData data);
	}
}
