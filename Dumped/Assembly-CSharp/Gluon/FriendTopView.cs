/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendTopView : FriendPanelBase
	{
		// Fields
		private static Action onHttpDone;
		[SerializeField]
		private Badge friendListBadge;
		[SerializeField]
		private Badge approvalWaitBadge;
	
		// Constructors
		public FriendTopView();
	
		// Methods
		public static FriendTopView Create(Transform parent, FriendScene scene);
		private void Start();
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		public static void OnEntryHttpSuccess(FriendFriendIndexResponse response);
	}
}
