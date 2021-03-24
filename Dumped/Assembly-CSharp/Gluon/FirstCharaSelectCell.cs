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
	public class FirstCharaSelectCell : TableViewCell<Gluon.FirstCharaSelectData>
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text charaName;
		[SerializeField]
		private GameObject checkMark;
		[SerializeField]
		private GameObject recommend;
		[SerializeField]
		private GameObject colleague;
		[SerializeField]
		private Transform charaIconTrans;
		[SerializeField]
		private Button summonButton;
		public Action<int> onSummonButtonClick;
		private int charaId;
	
		// Constructors
		public FirstCharaSelectCell();
	
		// Methods
		public override void UpdateContent(FirstCharaSelectData itemData);
		public void OnSummonButtonClick();
	}
}
