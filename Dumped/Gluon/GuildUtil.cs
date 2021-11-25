using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public static class GuildUtil
	{
		private const string createOrJoinPopupPath = "GuildCreateOrJoinPopup";

		public static void EntryToGuildScene(bool onErrorReturnToTitle = false, [Optional] UnityAction onClosePopup)
		{
		}

		public static void ReturnToMyPage()
		{
		}

		public static void GoGuildSceneAsync()
		{
		}

		public static void SetEmblemIcon(RawImage image, int emblemId, IconLoader.Size size = IconLoader.Size.M)
		{
		}

		public static bool HasMemberApprovalAuthority(GuildModel.Occupation occupation)
		{
			return default(bool);
		}

		public static bool HasMemberAdministrativeAuthority(GuildModel.Occupation occupation)
		{
			return default(bool);
		}

		public static bool HasGuildSettingAuthority(GuildModel.Occupation occupation)
		{
			return default(bool);
		}

		public static bool IsEnabledInvite([Optional] AtgenGuild guild)
		{
			return default(bool);
		}

		public static bool IsEnabledJoin(AtgenGuild guild)
		{
			return default(bool);
		}

		public static bool IsReceiveInvite()
		{
			return default(bool);
		}

		public static bool IsPenaltyTime()
		{
			return default(bool);
		}

		public static bool IsInGuildOrPenaltyTime()
		{
			return default(bool);
		}
	}
}
