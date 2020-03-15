using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ATM
{
    class Program
    {
        
        static int [] WaitTime(int N)
        {
            int[] waittime = new int[N];
            for (int i = 0; i < N; i++){
                waittime[i] = Convert.ToInt32(ReadLine());  //인출에 걸리는 시간 입력
            }
            WriteLine();
            return waittime;    
        }
        //줄 정리
        static void ArrangeLine(int[] vs)
        {
            int swap;
            for (int i = 0; i < vs.Length; i++){
                for (int j = i; j < vs.Length; j++){
                    if (vs[i] > vs[j]){
                        swap = vs[i];
                        vs[i] = vs[j];
                        vs[j] = swap;
                    }}
                WriteLine(vs[i]);
            }}
        //현금 인출
        static void WithDrawCash(int [] vs)
        {
            int sum = vs[0];
            for (int i = 1; i < vs.Length; i++)
            {
                vs[i] += vs[i - 1];
                sum += vs[i];
            }
            WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(ReadLine());    //줄의 길이 선언
            int[] waittime = WaitTime(N);          // 한명당 인출 시간 선언
            ArrangeLine(waittime);      //최적의 줄로 만들기
            WithDrawCash(waittime);     //인출시간 계산하기
        }
    }
}
