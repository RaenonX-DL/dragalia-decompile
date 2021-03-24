/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames.BasicApi.SavedGame
{
	public interface ISavedGameMetadata
	{
		// Properties
		bool IsOpen { get; }
		string Filename { get; }
		string Description { get; }
		string CoverImageURL { get; }
		TimeSpan TotalTimePlayed { get; }
		DateTime LastModifiedTimestamp { get; }
	}
}
