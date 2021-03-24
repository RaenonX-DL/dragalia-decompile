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
	public class MonsterLibraryListIcon : TableViewCell<Gluon.MonsterLibraryListData>
	{
		// Fields
		public Image newIcon;
		public Image monsterIcon;
		public Image elementIcon;
		public Image completeIcon;
		public UnityEngine.UI.Text pieceCount;
		[SerializeField]
		public StampListButtonEvent buttonPressed;
	
		// Constructors
		public MonsterLibraryListIcon();
	
		// Methods
		public override void UpdateContent(MonsterLibraryListData data);
		public void OnButtonPressed();
	}
}
