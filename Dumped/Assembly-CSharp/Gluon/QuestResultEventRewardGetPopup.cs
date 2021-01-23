/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultEventRewardGetPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private CommonIcon commonIcon;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
	
		// Constructors
		public QuestResultEventRewardGetPopup();
	
		// Methods
		public void Set(MazeEventRewardElement reward);
		public void Set(BuildEventRewardElement reward);
	}
}
