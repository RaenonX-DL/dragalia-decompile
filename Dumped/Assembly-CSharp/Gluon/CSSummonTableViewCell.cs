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
	public class CSSummonTableViewCell : TableViewCell<Gluon.SummonTopData.SwitchableSummonInfo>
	{
		// Fields
		public Image image;
		public SummonSwitchPopup switchPopup;
	
		// Constructors
		public CSSummonTableViewCell();
	
		// Methods
		public override void UpdateContent(SummonTopData.SwitchableSummonInfo info);
		public void OnItemPressed();
	}
}
