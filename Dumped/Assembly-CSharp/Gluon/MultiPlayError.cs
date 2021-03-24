/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon.LoadBalancing;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public struct MultiPlayError
	{
		// Fields
		[CompilerGenerated]
		private ErrorType _Type_k__BackingField;
		[CompilerGenerated]
		private int _DetailCode_k__BackingField;
		[CompilerGenerated]
		private object _Parameter_k__BackingField;
		private static readonly ErrorType[] _disconnectCauseToErrorTypeTable;
		private static readonly int[] _photonErrorCodeTable;
		private static readonly int DetailCodeOffset_DisconnectCause;
		private static readonly int DetailCodeOffset_InternalServerError;
		private static readonly int DetailCodeOffset_PhotonErrorCode;
	
		// Properties
		public ErrorType Type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int DetailCode { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object Parameter { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum ErrorType
		{
			None = 0,
			ServiceUnavailable = 1,
			NetworkError = 2,
			RoomFull = 3,
			RoomNotFound = 4,
			HostDisconnected = 5,
			RoomExpired = 6,
			AutoJoinRoomNotFound = 7,
			InternalPhotonError = 8,
			Unknown = 9,
			InvalidCompatibleId = 10
		}
	
		public enum OtherDetailCode
		{
			RoomAccessError = 1,
			OverSessionRetry = 2,
			UnexpectedRoomBrokenType = 3,
			UnexpectedDisconnection = 4,
			GetRegionsFailed = 5,
			EncryptionFailedToEstablish = 6,
			ConnectToRegionMasterFailed = 7,
			AutoJoinFailed = 8,
			UnexpectedRoomBroken = 9,
			PhotonAckTimeout = 10,
			Resume = 11,
			InRoomTimeout = 12,
			NoConnectableRegion = 13,
			PartySwitchTimeout = 14
		}
	
		// Constructors
		public MultiPlayError(ErrorType type, int detailCode, object parameter, string debugMessage);
		static MultiPlayError();
	
		// Methods
		public static MultiPlayError FromInternalServerError(InternalServerError internalServerError);
		public static MultiPlayError FromDisconnectCause(DisconnectCause cause);
		public static MultiPlayError FromOtherDetailCode(ErrorType type, OtherDetailCode detailCode, string debugString = null);
		public static MultiPlayError FromPhotonErrorCode(ErrorType type, int code, string debugString = null);
		public static MultiPlayError FromErrorType(ErrorType type);
		public static MultiPlayError Default();
		public static void CreateInternalServerErrorPopup(MultiPlayError error, Action onClose = null);
		private static int GetDetailCodeFromDisconnectCause(DisconnectCause cause);
		private static int GetDetailCodeFromPhotonErrorCode(int code);
		public static void ParseDetailCode(int detailCode);
		public override string ToString();
	}
}
