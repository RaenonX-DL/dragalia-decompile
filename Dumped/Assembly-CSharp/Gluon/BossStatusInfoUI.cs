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
	public class BossStatusInfoUI : PlayerStatusInfoUI
	{
		// Fields
		private List<AbnormalStatusBase> _abnormalStatusList;
	
		// Constructors
		public BossStatusInfoUI();
	
		// Methods
		protected override void CollectStatusInfo();
		private bool ApplyAbnormalStatusInfo(AbnormalStatusBase data, int startIndex, int endIndex, ref int index, ref int uiIndex);
		protected override CharaStatusInfoUI CreateStatusInfoUI();
	}
}
