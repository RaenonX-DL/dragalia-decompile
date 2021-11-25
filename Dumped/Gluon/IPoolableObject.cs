namespace Gluon
{
	public interface IPoolableObject
	{
		void Init();

		void Release();

		bool IsUsing();
	}
}
