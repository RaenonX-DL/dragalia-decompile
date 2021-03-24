/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PushMessageHolderModel
	{
		// Fields
		private static PushMessageHolderModel instance;
		[CompilerGenerated]
		private List<PushNoticeData> _pushMessageList_k__BackingField;
	
		// Properties
		public List<PushNoticeData> pushMessageList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static PushMessageHolderModel Instance { get; }
	
		// Constructors
		private PushMessageHolderModel();
		static PushMessageHolderModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceEmpty();
		public void Init();
		private void AddMessage(int id, string message);
		public bool isLoadGuildScene();
		[CompilerGenerated]
		private void _Init_b__9_0(int id, string msg);
	}
}
