using System;

public class MyStack
{
    private int[] arr;
	private int[] capacity;
	private int[] size;

    public MyStack(): this(4)
	{
		
	}

	public MyStack(int capacity)
	{
		this.capacity = capacity;
        arr = new int[capacity];
        size = 0;
    }

	public void Push(int value)
	{
		if(size < capacity)
		{
            arr[size++] = value;
        }
		else
		{
			throw new StackFullException();
		}
		
	}
}
