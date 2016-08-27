using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Monitor
{
    class SiemensPlc319F3
    {
        public static libnodave.daveOSserialType Fds; //объявление переменной типа подключения
        public static libnodave.daveInterface Di; //объявление переменной интерфейса подключения
        public static libnodave.daveConnection Dc; // объявление переменной подключения
        public static int Res; //объявление целочисленной переменной для результата, возращаемого функцией connectTo()
        public static int MemoryRes1;//объявление переменной для возвращаемого значения функцией ReadBytes
        public static int MemoryRes2;
        public static int MemoryRes3;
        public static int MemoryRes4;
        public static byte[] Buffer1 = new byte[20]; // обьявление одномерного массива размерностью Byte,
                                                                  // состоящего из 20 элементов, для хранения значений
                                                                  //из ПЛК
        public static byte[] Buffer2 = new byte[20];
        public static byte[] Buffer3 = new byte[12];
        public static byte[] Buffer4 = new byte[1];
        public static byte[] ThirdLinePb11Errors = new byte[53];//Массив всех ошибок пульта PB11

        //Функция коннекта
        public static void ConnectTo()
        {
            
            Fds.rfd = libnodave.openSocket(102, "192.168.0.1");
            Fds.wfd = Fds.rfd;
            Di = new libnodave.daveInterface(Fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
            Res = Di.initAdapter();
            Dc = new libnodave.daveConnection(Di, 0, 0, 2);
            Res = Dc.connectPLC();
            MemoryRes1 = Dc.readBytes(libnodave.daveDB, 13, 50, 20, Buffer1);//получаем в массив Buffer1 первый блок ошибок DB13DBX50.0 .. DB13DBX69.7
            MemoryRes2 = Dc.readBytes(libnodave.daveDB, 13, 90, 20, Buffer2);//получаем в массив Buffer2 второй блок ошибок DB13DBX90.0 .. DB13DBX109.7
            MemoryRes3 = Dc.readBytes(libnodave.daveDB, 13, 130, 12, Buffer3);//получаем в массив Buffer3 третий блок ошибок DB13DBX130.0 .. DB13DBX141.7
            MemoryRes4 = Dc.readBytes(libnodave.daveDB, 13, 143, 1, Buffer4);//получаем в массив Buffer4 первый блок ошибок DB13DBX143
            Buffer1.CopyTo(ThirdLinePb11Errors, 0);
            Buffer2.CopyTo(ThirdLinePb11Errors, Buffer1.Length);
            Buffer3.CopyTo(ThirdLinePb11Errors, Buffer1.Length + Buffer2.Length);
            Buffer4.CopyTo(ThirdLinePb11Errors, Buffer1.Length + Buffer2.Length + Buffer3.Length);
           
            Dc.disconnectPLC();
            Di.disconnectAdapter();
            libnodave.closePort(Fds.rfd);
        }
    }
}
