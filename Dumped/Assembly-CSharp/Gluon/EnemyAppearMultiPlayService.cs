/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyAppearMultiPlayService
	{
		// Fields
		private bool _isDirty;
		private EnemyAppear _tempSendEvent;
	
		// Constructors
		public EnemyAppearMultiPlayService();
	
		// Methods
		public void NotifyEnemyAppear(EnemyCharacter enemy);
		public void Flush();
		private void SendEnemyAppear();
		private void SetDirty();
	}
}
