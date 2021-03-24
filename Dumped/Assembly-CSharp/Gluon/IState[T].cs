/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class IState<T>
	{
		// Fields
		[CompilerGenerated]
		private StateMachine<T> _stateMachine_k__BackingField;
	
		// Properties
		public StateMachine<T> stateMachine { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string dispEnterLabel { get; }
		public string dispUpdateLabel { get; }
		public string dispExitLabel { get; }
		public T owner { get; }
	
		// Constructors
		protected IState();
	
		// Methods
		public void Build(StateMachine<T> stateMachine);
		public virtual void OnStateEnter();
		public virtual void OnStateUpdate();
		public virtual void OnStateExit();
	}
}
