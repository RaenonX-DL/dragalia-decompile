/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cute.Core;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonManager : FastUpdateMonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private PhotonClient _Client_k__BackingField;
		public static readonly int DefaultDisconnectionTimeout;
		private static readonly long MinSendAcksOnlyInterval;
		private static readonly long MaxSafeServiceInterval;
		public DateTime failResultRebattleStartTime;
		public RetryData retryData;
		private static bool _isCheatDetectionEnabled;
		private static bool _isCheatDetectionEnabledForBR;
		private static bool _forceRecordTimeAttackEnabled;
		private static bool _forceDoNotSynchronizePosition;
		[CompilerGenerated]
		private static PhotonManager _instance_k__BackingField;
		public static readonly int DefaultHostActorId;
		private long _lastSendAcksOnlyTicks;
		private PhotonPlayerProperty _localPlayerProperty;
		private PhotonRoomProperty _roomProperty;
		private bool _isDisconnecting;
	
		// Properties
		public PhotonClient Client { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool CheatDetectionEnabled { get; }
		public static bool CheatDetectionEnabledForBR { get; }
		public static bool ForceRecordTimeAttackEnabled { get; }
		public static bool ForceDoNotSynchronizePosition { get; }
		public static PhotonManager instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static bool IsHostMigrationEnabled { get; }
		public bool IsDisconnecting { get; }
		public bool IsSolo { get; }
	
		// Nested types
		public struct RetryData
		{
			// Fields
			public int questId;
			public bool isHost;
			public int lastQuestStartPlayerCount;
		}
	
		// Constructors
		public PhotonManager();
		static PhotonManager();
	
		// Methods
		public static void Create();
		public static void Destroy();
		public static void SendAcksOnly();
		private void Awake();
		private void OnDestroy();
		public PhotonConnectTarget.ServiceTypes Connect(string userId = null, string clusterName = null);
		public void Disconnect(string reason);
		public void DisconnectImmediately();
		public override void FastUpdate();
		private void OnApplicationQuit();
		public bool TryGetPlayerProperty(int actorId, string key, out int value);
		public bool TrySetPlayerProperty(string key, int value);
		public bool TrySetPlayerProperty(string key, string value);
		public bool TryGetOwnPlayerPropertySafe(string key, out object value);
		public bool TryGetPlayerPropertySafe(Player player, string key, out object value);
		public bool TrySetOwnPlayerPropertySafe(string key, object value);
		public bool TryGetRoomProperty(string key, out object value);
		public bool TrySetRoomPropertySafe(string key, object value);
		public void SendDisconnectReasonLog(string extendMessage);
		public void SendPhotonErrorLog(string errorType, StringBuilder builder = null);
		public void SendPhotonSpecifiedErrorLog(string errorType, StringBuilder builder = null);
		public void ResendProperty();
		private void OnOperationResponse(OperationResponse operationResponse);
	}
}
