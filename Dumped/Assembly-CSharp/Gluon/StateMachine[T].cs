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
	public class StateMachine<T>
	{
		// Fields
		[CompilerGenerated]
		private T _owner_k__BackingField;
		[CompilerGenerated]
		private IState<T> _current_k__BackingField;
		[CompilerGenerated]
		private IState<T> _next_k__BackingField;
		[CompilerGenerated]
		private IState<T> _prev_k__BackingField;
		private Dictionary<Type, IState<T>> states;
	
		// Properties
		public T owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IState<T> current { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IState<T> next { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IState<T> prev { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public StateMachine(T owner);
	
		// Methods
		public U GetState<U>()
			where U : IState<T>, new();
		public U SetState<U>(bool immediate = false)
			where U : IState<T>, new();
		public IState<T> SetState(IState<T> state, bool immediate = false);
		public void Update();
	}
}
