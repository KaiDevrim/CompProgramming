namespace Neetcode.Solutions.Solutions;

public class DynamicArray
{
    private int[] _dynamicArray;
    private int _items;
    private int _totalSize;
    public DynamicArray(int capacity)
    {
         _dynamicArray = new int[capacity];
         _totalSize = capacity;
    }

    public int Get(int i)
    {
        return _dynamicArray[i];
    }

    public void Set(int i, int n)
    {
        _dynamicArray[i] = n;
        _items++;
    }

    public void PushBack(int n) {
        if (_items == _totalSize) {
            Resize();
        }
        Set(_totalSize-1, n);
    }

    public int PopBack()
    {
        if (_totalSize > 0)
        {
            _totalSize--;
        }

        return _dynamicArray[_totalSize];
    }

    private void Resize()
    {
        int tempSize = _totalSize * 2;
        int[] tempArray = new int[tempSize];
        for (int i = 0; i < _totalSize; i++)
        {
            tempArray[i] = _dynamicArray[i];
        }
        _totalSize = tempSize;
        _dynamicArray = tempArray;
    }

    public int GetSize()
    {
        return _items;
    }

    public int GetCapacity()
    {
        return _totalSize;
    }
}