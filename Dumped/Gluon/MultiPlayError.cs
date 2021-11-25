using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Event;

namespace Gluon
{
	[StructLayout(0, Size = 16)]
	public struct MultiPlayError
	{
		public enum ErrorType
		{
			None,
			ServiceUnavailable,
			NetworkError,
			RoomFull,
			RoomNotFound,
			HostDisconnected,
			RoomExpired,
			AutoJoinRoomNotFound,
			InternalPhotonError,
			Unknown,
			InvalidCompatibleId
		}

		public enum OtherDetailCode
		{
			Reserved = 1,
			OverSessionRetry,
			UnexpectedRoomBrokenType,
			UnexpectedDisconnection,
			GetRegionsFailed,
			EncryptionFailedToEstablish,
			ConnectToRegionMasterFailed,
			AutoJoinFailed,
			UnexpectedRoomBroken,
			PhotonAckTimeout,
			Resume,
			InRoomTimeout,
			NoConnectableRegion,
			PartySwitchTimeout,
			RoomAccessError
		}

		private static readonly ErrorType[] _disconnectCauseToErrorTypeTable;

		private static readonly int[] _photonErrorCodeTable;

		private static readonly int DetailCodeOffset_DisconnectCause;

		private static readonly int DetailCodeOffset_InternalServerError;

		private static readonly int DetailCodeOffset_PhotonErrorCode;

		public ErrorType Type
		{
			[CompilerGenerated]
			get
			{
				return default(ErrorType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int DetailCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public object Parameter
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

		public MultiPlayError(ErrorType type, int detailCode, object parameter, string debugMessage)
		{
		}

		public static MultiPlayError FromInternalServerError(InternalServerError internalServerError)
		{
			return default(MultiPlayError);
		}

		public static MultiPlayError FromDisconnectCause(DisconnectCause cause)
		{
			return default(MultiPlayError);
		}

		public static MultiPlayError FromOtherDetailCode(ErrorType type, OtherDetailCode detailCode, [Optional] string debugString)
		{
			return default(MultiPlayError);
		}

		public static MultiPlayError FromPhotonErrorCode(ErrorType type, int code, [Optional] string debugString)
		{
			return default(MultiPlayError);
		}

		public static MultiPlayError FromErrorType(ErrorType type)
		{
			return default(MultiPlayError);
		}

		public static MultiPlayError Default()
		{
			return default(MultiPlayError);
		}

		public static void CreateInternalServerErrorPopup(MultiPlayError error, [Optional] Action onClose)
		{
		}

		private static int GetDetailCodeFromDisconnectCause(DisconnectCause cause)
		{
			return default(int);
		}

		private static int GetDetailCodeFromPhotonErrorCode(int code)
		{
			return default(int);
		}

		public static void ParseDetailCode(int detailCode)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
