/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Events
{
	public interface IEvent
	{
		// Properties
		string Id { get; }
		string Name { get; }
		string Description { get; }
		string ImageUrl { get; }
		ulong CurrentCount { get; }
		EventVisibility Visibility { get; }
	}
}
