class Person
{
    //객체 이니셜라이저 사용
    //Foo foo1 = new Foo() { name = "foo", value = 3 };
    //Foo foo2 = new Foo("foo") { value = 3 };

    //사실상 위는 아래와 동일
    Foo foo3 = new Foo();
    Foo foo4 = new Foo("foo");
    void Init()
    {
        foo3.name = "foo";
        foo3.value = 3;

        foo4.value = 5;
    }

}

class Foo
{
    public string name;
    public int value;

    public Foo() {}

    public Foo(string name)
    {
        this.name = name;
    }

    //public Foo(string name) => this.name = name;

}