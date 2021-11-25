using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Common;

namespace Gluon
{
	public class PhotonClient : LoadBalancingClient
	{
		public static readonly PhotonEventSerializerType eventSerializerType;

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

		public bool IsEventProcessing
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CurrentRoomMemberCount => default(int);

		public event Action<OperationResponse> onOperationResponse
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<StatusCode> onStatusChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<EventData> onEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action onDisconnected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static RaiseEventOptions SendToOne(int actorId)
		{
			return null;
		}

		public PhotonClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		public PhotonClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		public override void OnStatusChanged(StatusCode statusCode)
		{
		}

		public override void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		public override void OnEvent(EventData photonEvent)
		{
		}

		public override void DebugReturn(DebugLevel level, string message)
		{
		}

		public void RaiseEvent(Gluon.Common.EventCode eventCode, RaiseEventOptions option)
		{
		}

		public void RaiseEventToOthers<T>(Gluon.Common.EventCode eventCode, EventBase<T> obj) where T : EventBase<T>
		{
		}

		public void RaiseEvent<T>(Gluon.Common.EventCode eventCode, EventBase<T> obj, RaiseEventOptions option) where T : EventBase<T>
		{
		}

		protected bool OpRaiseEventEncrypted(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		public new bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		public new bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		public new void Disconnect()
		{
		}

		public new void Service()
		{
		}

		public void BeginSequenceCheck()
		{
		}

		public void EndSequenceCheck()
		{
		}

		public void OnReceiveSequenceId(Gluon.Common.EventCode code, int actorId, ushort sequenceId)
		{
		}
	}
}
