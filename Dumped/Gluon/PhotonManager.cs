using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cute.Core;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;

namespace Gluon
{
	public class PhotonManager : FastUpdateMonoBehaviour
	{
		public struct RetryData
		{
			public int questId;

			public bool isHost;

			public int lastQuestStartPlayerCount;
		}

		public static readonly int DefaultDisconnectionTimeout;

		private static readonly long MinSendAcksOnlyInterval;

		private static readonly long MaxSafeServiceInterval;

		public DateTime failResultRebattleStartTime;

		public RetryData retryData;

		private static bool _isCheatDetectionEnabled;

		private static bool _isCheatDetectionEnabledForBR;

		private static bool _forceRecordTimeAttackEnabled;

		private static bool _forceDoNotSynchronizePosition;

		public static readonly int DefaultHostActorId;

		private long _lastSendAcksOnlyTicks;

		private PhotonPlayerProperty _localPlayerProperty;

		private PhotonRoomProperty _roomProperty;

		private bool _isDisconnecting;

		public PhotonClient Client
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool CheatDetectionEnabled => default(bool);

		public static bool CheatDetectionEnabledForBR => default(bool);

		public static bool ForceRecordTimeAttackEnabled => default(bool);

		public static bool ForceDoNotSynchronizePosition => default(bool);

		public static PhotonManager instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static bool IsHostMigrationEnabled => default(bool);

		public bool IsDisconnecting => default(bool);

		public bool IsSolo => default(bool);

		public static void Create()
		{
		}

		public static void Destroy()
		{
		}

		public static void SendAcksOnly()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public PhotonConnectTarget.ServiceTypes Connect([Optional] string userId, [Optional] string clusterName)
		{
			return default(PhotonConnectTarget.ServiceTypes);
		}

		public void Disconnect(string reason)
		{
		}

		public void DisconnectImmediately()
		{
		}

		public override void FastUpdate()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public bool TryGetPlayerProperty(int actorId, string key, out int value)
		{
			return default(bool);
		}

		public bool TrySetPlayerProperty(string key, int value)
		{
			return default(bool);
		}

		public bool TrySetPlayerProperty(string key, string value)
		{
			return default(bool);
		}

		public bool TryGetOwnPlayerPropertySafe(string key, out object value)
		{
			return default(bool);
		}

		public bool TryGetPlayerPropertySafe(Player player, string key, out object value)
		{
			return default(bool);
		}

		public bool TrySetOwnPlayerPropertySafe(string key, object value)
		{
			return default(bool);
		}

		public bool TryGetRoomProperty(string key, out object value)
		{
			return default(bool);
		}

		public bool TrySetRoomPropertySafe(string key, object value)
		{
			return default(bool);
		}

		public void SendDisconnectReasonLog(string extendMessage)
		{
		}

		public void SendPhotonErrorLog(string errorType, [Optional] StringBuilder builder)
		{
		}

		public void SendPhotonSpecifiedErrorLog(string errorType, [Optional] StringBuilder builder)
		{
		}

		public void ResendProperty()
		{
		}

		private void OnOperationResponse(OperationResponse operationResponse)
		{
		}
	}
}
