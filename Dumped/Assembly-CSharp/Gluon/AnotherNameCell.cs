/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnotherNameCell : TableViewCell<Gluon.AnotherNameCellData>
	{
		// Fields
		public Image rarityIcon;
		public UnityEngine.UI.Text rubyText;
		public UnityEngine.UI.Text nameText;
		public Image newIcon;
		public Image selectIcon;
		public UnityEngine.UI.Text notObtainedText;
		[SerializeField]
		public UnityAction<int> buttonPressed;
	
		// Constructors
		public AnotherNameCell();
	
		// Methods
		public override void UpdateContent(AnotherNameCellData data);
		public void OnButtonPressed();
	}
}
