namespace ConsoleApp32
{
    /*인터페이스
    메소드, 이벤트, 인덱서 속성.
    필드X
    public이 기본
    추상적
    구현부를 가지지 않음. 몸통 없이 정의. 추상
    */
    interface ParentInterface
    {
        void myMethod(string str);
    }

    interface SubInterface : ParentInterface
    {
        void myMethod(string str, int i);
    }

    class InterTestClass : SubInterface
    {
        public void myMethod(string str)
        {
            Console.WriteLine($"{str} ParentInterface.myMethod() call");
        }

        public void myMethod(string str, int count)
        {
            for(int i = 0; i<count; i++)
            {
                Console.WriteLine($"{str} SubInterface.myMethod() {i} call!");
            }
        }
    }

    class UseProgram
    {
        public void Run()
        {
            InterTestClass interTestClass = new InterTestClass();

            interTestClass.myMethod("Interface");
            interTestClass.myMethod("Inherits", 4);
        }
    }
    interface IMyInterfaceA
    {
        void print();
    }

    interface IMyInterfaceB
    {
        void print();
    }

    class InterfaceScript : IMyInterfaceA, IMyInterfaceB
    {
        public void MainMethod()
        {
            InterfaceScript mc = new InterfaceScript();
            IMyInterfaceA imca = mc;
            imca.print();

            IMyInterfaceB imcb = mc;
            imcb.print();

        }

        void IMyInterfaceA.print()
        {
            Console.WriteLine("IMyintefaceA.print() 호출.");
        }

        void IMyInterfaceB.print()
        {
            Console.WriteLine("IMyinterfaceB.pritn() 호출");
        }
    }
}