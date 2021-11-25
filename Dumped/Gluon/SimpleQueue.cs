namespace Gluon
{
	public class SimpleQueue<T> where T : IReplicable<T>, ICleanable, new()
	{
		private int qmax;

		private int n;

		private int ptr;

		private T[] data;

		public SimpleQueue(int max)
		{
		}

		public void Flush()
		{
		}

		public bool EnQueue(T d)
		{
			return default(bool);
		}

		public void DeQueue()
		{
		}

		public T Get()
		{
			return (T)null;
		}

		public T Get(int offset)
		{
			return (T)null;
		}

		public int Count()
		{
			return default(int);
		}

		public bool IsEmpty()
		{
			return default(bool);
		}

		public bool IsFull()
		{
			return default(bool);
		}
	}
}
