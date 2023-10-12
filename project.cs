using System;

namespace Hello
{
  class Project
  {
    static void Main()
    {
      MyList list = new MyList();

      list.Add("1");
      list.Add("2");
      list.Add("3");
      for (int i = 0; i <= list.Length(); i++)
      {
        Console.WriteLine(list.get(i));
      }
      list.Add("4");
      Console.WriteLine(list.get(4));
    }
  }

  public class MyList
  {
    private string[] array;
    private int length;
    private int lastIndex;

    public MyList()
    {
      array = new string[3];
      length = array.Length;
      lastIndex = 0;
    }

    public void Add(string item)
    {
      if (length == lastIndex + 1)
      {
        MakeItBigger();
      }

      lastIndex++;
      array[lastIndex] = item;
    }

    private void MakeItBigger()
    {
      string[] tmp = array;
      array = new string[length + 3];
      for (int i = 0; i < tmp.Length; i++)
      {
        array[i] = tmp[i];
      }
      length = array.Length;
    }

    public string get(int index) { return array[index]; }
    public int Length() { return lastIndex; }
    public int Size() { return length; }

  }
}
