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
	public class FriendListCell : TableViewCell<Gluon.FriendListCellData>
	{
		// Fields
		[SerializeField]
		private CommonFriendListCell commonFriendListCell;
		[SerializeField]
		private Image newIconImage;
		[SerializeField]
		private Button listOnButtonRightNormal;
		[SerializeField]
		private Button listOnButtonRightBlue;
		[SerializeField]
		private UnityEngine.UI.Text listOnButtonRightText;
		[SerializeField]
		private Button listOnButtonLeft;
		[SerializeField]
		private UnityEngine.UI.Text listOnButtonLeftText;
		[SerializeField]
		private Button listOnButtonJoin;
		[SerializeField]
		private UnityEngine.UI.Text listOnButtonJoinText;
		[SerializeField]
		private Shader exchangeShader;
		private FriendListCellData data;
	
		// Constructors
		public FriendListCell();
	
		// Methods
		public override void UpdateContent(FriendListCellData data);
		public void OnRightButtonPressed();
		public void OnLeftButtonPressed();
		public void OnJoinButtonPressed();
	}
}
