using System.Runtime.InteropServices;

[StructLayout(3, Size = 4)]
public enum OmoteRequestType
{
	Session,
	LaunchFromPush,
	DeviceTokenReceived,
	IsEnabledPush,
	Event,
	Undefined
}
