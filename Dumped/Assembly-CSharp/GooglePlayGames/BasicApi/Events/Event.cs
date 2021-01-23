/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.Events
{
	internal class Event : IEvent
	{
		// Fields
		private string mId;
		private string mName;
		private string mDescription;
		private string mImageUrl;
		private ulong mCurrentCount;
		private EventVisibility mVisibility;
	
		// Properties
		public string Id { get; }
		public string Name { get; }
		public string Description { get; }
		public string ImageUrl { get; }
		public ulong CurrentCount { get; }
		public EventVisibility Visibility { get; }
	
		// Constructors
		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility);
	}
}
