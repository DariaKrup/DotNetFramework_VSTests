using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using Xunit;


namespace TestProject1
{
    public class Traitexample
    {
        [Fact]
[Trait("Category1","Unit")]
public void Test1(){
   }

[Fact]
[Trait("Category","Integration")]
public void Test2(){
    }

[Fact]
[Trait("Category","UI")]
public void Test3(){
    }
    }
}
