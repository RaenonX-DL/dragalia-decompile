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
	public class QRFriendApplyInfoPopup : QuestResultCommonPopup
	{
		// Fields
		[SerializeField]
		public Transform cellTrans;
		[SerializeField]
		public GameObject cell;
	
		// Constructors
		public QRFriendApplyInfoPopup();
	
		// Methods
		public static QRFriendApplyInfoPopup Create(Action onOK = null);
		protected override void Start();
		public override void OnOKOrClosePopup();
	}
}
