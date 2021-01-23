/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QREventRewardPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private Transform cellTransform;
		[SerializeField]
		private UnityEngine.UI.Text randomInfoText;
		[SerializeField]
		private UnityEngine.UI.Text buildInfoText;
	
		// Constructors
		public QREventRewardPopup();
	
		// Methods
		protected override void Start();
		public void SetContent(List<MazeEventRewardElement> gotRewards);
		public void SetContent(int eventId, List<BuildEventRewardElement> gotRewards);
		public static string GetEventItemName();
	}
}
