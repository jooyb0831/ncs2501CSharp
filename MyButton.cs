class MyButton
{
    public string Text;

    //이벤트 정의
    public event EventHandler Click;

    public void MouseButton()
    {
        if(this.Click != null)
        {
            //이벤트 핸들러들을 호출
            Click(this, EventArgs.Empty);
        }
    }

    public void Run()
    {
        MyButton btn = new MyButton();
        //Click 이벤트에 대한 이벤트 핸들러로
        //btn_Click이라는 매서드를 지정함
        btn.Click += new EventHandler(btn_Click); //이벤트 가입(+=) 탈퇴(-=)
        btn.Text = "Run";
    }

    void btn_Click(Object sender, EventArgs e)
    {
        Console.WriteLine("Button 클릭");
    }
}