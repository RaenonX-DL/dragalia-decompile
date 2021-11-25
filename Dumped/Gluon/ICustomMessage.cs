namespace Gluon
{
	public interface ICustomMessage
	{
		void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
