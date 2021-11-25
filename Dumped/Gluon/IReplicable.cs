namespace Gluon
{
	public interface IReplicable<T>
	{
		void Replicate(T other);
	}
}
