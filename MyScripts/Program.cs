namespace MyScripts
{
    public class FillArray
    {
        int[] storage = new int[0];
        int count = 0;
        public void Add(int item)
        {
            Array.Resize(ref storage, count + 1);
            storage[count++] = item;
        }
        public int GetValue(int index)
        {
            return storage[index];
        }
    }
} 