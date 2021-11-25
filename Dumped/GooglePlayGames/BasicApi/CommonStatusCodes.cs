namespace GooglePlayGames.BasicApi
{
	public enum CommonStatusCodes
	{
		SuccessCached = -1,
		Success = 0,
		ServiceMissing = 1,
		ServiceVersionUpdateRequired = 2,
		ServiceDisabled = 3,
		SignInRequired = 4,
		InvalidAccount = 5,
		ResolutionRequired = 6,
		NetworkError = 7,
		InternalError = 8,
		ServiceInvalid = 9,
		DeveloperError = 10,
		LicenseCheckFailed = 11,
		Error = 13,
		Interrupted = 14,
		Timeout = 0xF,
		Canceled = 0x10,
		ApiNotConnected = 17,
		AuthApiInvalidCredentials = 3000,
		AuthApiAccessForbidden = 3001,
		AuthApiClientError = 3002,
		AuthApiServerError = 3003,
		AuthTokenError = 3004,
		AuthUrlResolution = 3005
	}
}
