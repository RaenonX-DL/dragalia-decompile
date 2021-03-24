/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyCtrlChecker
	{
		// Fields
		private bool _isEnabled;
		private bool _isInExecScript;
		private bool _didActionIdSet;
		private static readonly int CheckErrorThreshold;
		private float _checkErrorTimer;
		private int _enemyId;
	
		// Constructors
		public EnemyCtrlChecker(int id);
		static EnemyCtrlChecker();
	
		// Methods
		public void BeginExecScript();
		public void EndExecScript();
		public void NotifySetActionId();
		public void NotifySetupSoloAI();
		private void Error();
	}
}
