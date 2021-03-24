/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PuppetMasterUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private bool isBooting;
		private int _bootActionId;
		private int _abortActionId;
		private float _timer;
	
		// Constructors
		public PuppetMasterUniqueCtrl();
	
		// Methods
		public void Setup(int bootActionId, int abortActionId);
		private void Update();
		public void Boot(float runningTime);
		public void Abort();
		private void ProcAbort();
	}
}
