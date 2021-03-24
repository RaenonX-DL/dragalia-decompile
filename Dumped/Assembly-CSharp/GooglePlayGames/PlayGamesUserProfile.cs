/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace GooglePlayGames
{
	public class PlayGamesUserProfile : IUserProfile
	{
		// Fields
		private string mDisplayName;
		private string mPlayerId;
		private string mAvatarUrl;
		private bool mIsFriend;
		private bool mImageLoading;
		private Texture2D mImage;
	
		// Properties
		public string userName { get; }
		public string id { get; }
		public string gameId { get; }
		public bool isFriend { get; }
		public UserState state { get; }
		public Texture2D image { get; }
		public string AvatarURL { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LoadImage_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PlayGamesUserProfile __4__this;
			private UnityWebRequest _www_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadImage_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl);
		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl, bool isFriend);
	
		// Methods
		protected void ResetIdentity(string displayName, string playerId, string avatarUrl);
		[IteratorStateMachine]
		internal IEnumerator LoadImage();
		public override bool Equals(object obj);
		public override int GetHashCode();
		public override string ToString();
		private void setAvatarUrl(string avatarUrl);
	}
}
