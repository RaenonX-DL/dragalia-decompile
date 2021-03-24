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
	public class BattleRoyalRecordInfoPopup : PopupBase
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text totalTop1CountText;
		public UnityEngine.UI.Text totalTop4CountText;
		public UnityEngine.UI.Text mostUsedJobText;
		public UnityEngine.UI.Text killTotalCountText;
		public UnityEngine.UI.Text maxKillCountPerGameText;
		public UnityEngine.UI.Text totalPointText;
	
		// Constructors
		public BattleRoyalRecordInfoPopup();
	
		// Methods
		public static BattleRoyalRecordInfoPopup Create();
		protected override void Start();
		private void ApplyTopCountLocalize(UnityEngine.UI.Text text, int c);
		public void OnRecordListButtonPressed();
	}
}
