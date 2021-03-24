/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QSTableTopViewCell : QuestCommonTableViewCell<Gluon.QSTableViewData>
	{
		// Fields
		[SerializeField]
		private QSTableViewController _parentViewController;
	
		// Properties
		public QSTableViewController parentViewController { get; }
	
		// Constructors
		public QSTableTopViewCell();
	
		// Methods
		public override void OnClick();
		public override void UpdateContent(QSTableViewData data);
	}
}
