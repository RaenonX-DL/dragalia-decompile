/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HeaderPushMessage : HeaderMessageBase<Gluon.PushNoticeData>
	{
		// Fields
		public bool isStopPushAnim;
	
		// Constructors
		public HeaderPushMessage();
	
		// Methods
		private void Start();
		private void Update();
		protected override void OnDestroy();
		protected override bool isShowOtherNotice();
		protected override bool IsWaitNeeded();
	}
}
