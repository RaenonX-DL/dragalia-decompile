/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMissionDetailPopup : CommonPopup
	{
		// Fields
		public QuestMissionElement[] uiMissionElementArray;
	
		// Constructors
		public QuestMissionDetailPopup();
	
		// Methods
		public static QuestMissionDetailPopup Create(int questId, bool showBlackLayer = true);
		private void ReflectData(int questID);
	}
}
