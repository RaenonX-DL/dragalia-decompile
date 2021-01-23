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
	public class ExchangeSummonSelectItemCell : TableViewCell<Gluon.ExchangeSummonSelectItemCellData>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text charaName;
		[SerializeField]
		private GameObject colleague;
		[SerializeField]
		private Transform charaIconTrans;
		[SerializeField]
		private Button summonButton;
		[SerializeField]
		private UnityEngine.UI.Text countText;
		public Action<ExchangeSummonSelectItemCellData> onSummonButtonClick;
		private ExchangeSummonSelectItemCellData data;
	
		// Constructors
		public ExchangeSummonSelectItemCell();
	
		// Methods
		public override void UpdateContent(ExchangeSummonSelectItemCellData itemData);
		public void OnSummonButtonClick();
	}
}
