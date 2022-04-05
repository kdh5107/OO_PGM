using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
  class Kim
  {
    public string name = "김도형";
  }

  class Student : Kim
  {
    public void Name()
    {
      Console.WriteLine("학생의 이름은 " + name + "입니다.");
    }
  }

  class Test
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      student.Name();
    }
  }
}
