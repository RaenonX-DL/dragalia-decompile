/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendListCellData
	{
		// Fields
		public UserSupportList friendData;
		public FriendModel.PanelType type;
		public UnityAction<FriendListCellData> rightButtonPressedCallback;
		public UnityAction<FriendListCellData> leftButtonPressedCallback;
		public UnityAction<FriendListCellData> joinButtonPressedCallback;
	
		// Constructors
		public FriendListCellData();
	
		// Methods
		public CommonFriendListCellData GetCommonData();
	}
}
