using Gluon.ActionData;

namespace Gluon
{
	public class ActionPartsScaleBlast : ActionParts
	{
		public enum ChildType
		{
			Black,
			White,
			Both
		}

		public enum ChildParam
		{
			Child01Param,
			Child02Param,
			Child03Param
		}

		private enum State
		{
			Init,
			Idle,
			Play,
			Wait,
			Attack,
			Fail
		}

		private readonly ScaleBlastData _partsData;

		private State _state;

		private EnemyCharacter _enemy;

		private float _idleTime;

		private float _waiting;

		private int _blastActionId;

		private bool _isPlayDone;

		public ActionPartsScaleBlast(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void OnPostCreated(CharacterBase chara)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private bool Play()
		{
			return default(bool);
		}

		private int GetChildParamId(ChildParam param)
		{
			return default(int);
		}

		private void PlayAction(int actionId)
		{
		}
	}
}
