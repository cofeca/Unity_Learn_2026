using System;
//定义 int 变量 week（1-7）；
//switch 判断：1 = 周一，2 = 周二…7 = 周日，输出对应文字。
namespace Game
{
    class WeekDay
    {
        int week;
        public void SetWeek()
        {
            week = 2;
        }
        public string TodayIs()
        {
            switch (week)
            {
                case 1:
                    return "今天是星期一";
   
                case 2:
                    return "今天是星期二";
                    
                case 3:
                    return "今天是星期三";
                    
                case 4:
                    return "今天是星期四";
                    
                case 5:
                    return "今天是星期五";
                    
                case 6:
                    return "今天是星期六";
                    
                case 7:
                    return "今天是星期日";
                    
                default:
                    return "数据错误";
                    
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeekDay weekDay = new WeekDay();
            weekDay.SetWeek();
            Console.WriteLine(weekDay.TodayIs());
            Console.ReadLine();
        }

    }
}
























