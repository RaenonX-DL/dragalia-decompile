/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Common;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonClient : LoadBalancingClient
	{
		// Fields
		public static readonly PhotonEventSerializerType eventSerializerType;
		[CompilerGenerated]
		private Action<OperationResponse> onOperationResponse;
		[CompilerGenerated]
		private Action<StatusCode> onStatusChanged;
		[CompilerGenerated]
		private Action<EventData> onEvent;
		[CompilerGenerated]
		private Action onDisconnected;
		private readonly Dictionary<byte, object> opParameters;
		public StatusCode lastStatusCode;
		public string lastErrorMessage;
		public string lastWarningMessage;
		private ClientState lastState;
		private bool needToNotifyDisconnection;
		public static readonly RaiseEventOptions SendToOthers;
		public static readonly RaiseEventOptions SendToAll;
		public static readonly RaiseEventOptions SendToHost;
		private static RaiseEventOptions _sendToOneOption;
		private bool _isDisconnectionDetected;
		private PhotonSequenceCheck _sequenceCheck;
		[CompilerGenerated]
		private bool _IsEventProcessing_k__BackingField;
	
		// Properties
		public bool IsEventProcessing { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int CurrentRoomMemberCount { get; }
	
		// Events
		public event Action<OperationResponse> onOperationResponse {
			add;
			remove;
		}
		public event Action<StatusCode> onStatusChanged {
			add;
			remove;
		}
		public event Action<EventData> onEvent {
			add;
			remove;
		}
		public event Action onDisconnected {
			add;
			remove;
		}
	
		// Constructors
		public PhotonClient(ConnectionProtocol protocol = ConnectionProtocol.Udp);
		public PhotonClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp);
		static PhotonClient();
	
		// Methods
		public static RaiseEventOptions SendToOne(int actorId);
		public override void OnStatusChanged(StatusCode statusCode);
		public override void OnOperationResponse(OperationResponse operationResponse);
		public override void OnEvent(EventData photonEvent);
		public override void DebugReturn(DebugLevel level, string message);
		public void RaiseEvent(Gluon.Common.EventCode eventCode, RaiseEventOptions option);
		public void RaiseEventToOthers<T>(Gluon.Common.EventCode eventCode, EventBase<T> obj)
			where T : EventBase<T>;
		public void RaiseEvent<T>(Gluon.Common.EventCode eventCode, EventBase<T> obj, RaiseEventOptions option)
			where T : EventBase<T>;
		protected bool OpRaiseEventEncrypted(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions);
		public new bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues);
		public new bool ConnectToRegionMaster(string region);
		public new void Disconnect();
		public new void Service();
		public void BeginSequenceCheck();
		public void EndSequenceCheck();
		public void OnReceiveSequenceId(Gluon.Common.EventCode code, int actorId, ushort sequenceId);
	}
}
