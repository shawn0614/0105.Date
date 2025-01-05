namespace _0105.Date
{
    public partial class Form1 : Form
    {
        private int _Month, _Date, _DayCount;
        private string _Day;
        private string[] _Week = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _Month = 1;
            _Date = 1;
            _DayCount = 2;
            _Day = _Week[2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Month > 12)
            {
                return;
            }
            if (_Month == 2)
            {
                if (_Date == 28) 
                {
                    _Month++;
                    _Date = 1;
                }
                else
                {
                    _Date++;
                }
            }
            else if (_Month <= 7)
            {
                if (_Month % 2  == 1)
                {
                    if (_Date == 31)
                    {
                        _Month++;
                        _Date = 1;
                    }
                    else
                    {
                        _Date++;
                    }
                }
                else
                {
                    if (_Date == 30)
                    {
                        _Month++;
                        _Date = 1;
                    }
                    else
                    {
                        _Date++;
                    }
                }
            }
            else
            {
                if (_Month % 2 == 0)
                {
                    if (_Date == 31)
                    {
                        _Month++;
                        _Date = 1;
                    }
                    else
                    {
                        _Date++;
                    }
                }
                else
                {
                    if (_Date == 30)
                    {
                        _Month++;
                        _Date = 1;
                    }
                    else
                    {
                        _Date++;
                    }
                }
            }
            if (_DayCount == 6)
            {
                _DayCount = 0;
                _Day = _Week[_DayCount];
            }
            else
            {
                _DayCount++;
                _Day = _Week[_DayCount];
            }
            label1.Text ="M."+ _Month;
            label2.Text = "D." + _Date;
            label3.Text = "Day " + _Day;
        }
    }
}
