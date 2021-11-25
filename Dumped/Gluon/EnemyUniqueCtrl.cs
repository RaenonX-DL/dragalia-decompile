using Cute.Core;
using Gluon.Event;

namespace Gluon
{
	public class EnemyUniqueCtrl : FastUpdateMonoBehaviour
	{
		protected EnemyCharacter _character;

		public EnemyCharacter character => null;

		public virtual void Initialize()
		{
		}

		public virtual float GetAtkValue()
		{
			return default(float);
		}

		public virtual float GetDefValue()
		{
			return default(float);
		}

		public virtual void OnChangeState(CharacterState state)
		{
		}

		public virtual void OnDisconnectUser(int disconnectActorId)
		{
		}

		public virtual void OnReceiveActionPartsNotifyEvent(ActionPartsNotifyEvent recvEvent)
		{
		}

		public virtual void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent)
		{
		}
	}
}
