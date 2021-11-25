using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesUserProfile : IUserProfile
	{
		private string mDisplayName;

		private string mPlayerId;

		private string mAvatarUrl;

		private bool mIsFriend;

		private bool mImageLoading;

		private Texture2D mImage;

		public string userName => null;

		public string id => null;

		public string gameId => null;

		public bool isFriend => default(bool);

		public UserState state => default(UserState);

		public Texture2D image => null;

		public string AvatarURL => null;

		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl)
		{
		}

		internal PlayGamesUserProfile(string displayName, string playerId, string avatarUrl, bool isFriend)
		{
		}

		protected void ResetIdentity(string displayName, string playerId, string avatarUrl)
		{
		}

		internal IEnumerator LoadImage()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override string ToString()
		{
			return null;
		}

		private void setAvatarUrl(string avatarUrl)
		{
		}
	}
}
