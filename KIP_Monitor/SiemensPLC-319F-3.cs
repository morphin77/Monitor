using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Monitor
{
    class SiemensPLC_319F_3
    {
        public static libnodave.daveOSserialType fds; //объявление переменной типа подключения
        public static libnodave.daveInterface di; //объявление переменной интерфейса подключения
        public static libnodave.daveConnection dc; // объявление переменной подключения
        public static int res; //объявление целочисленной переменной для результата, возращаемого функцией connectTo()
        public static int memoryRes1;//объявление переменной для возвращаемого значения функцией ReadBytes
        public static int memoryRes2;//объявление переменной для возвращаемого значения функцией ReadBytes
        public static int memoryRes3;//объявление переменной для возвращаемого значения функцией ReadBytes
        public static byte[] ThreeLinePB11Errors1 = new byte[19]; // обьявление одномерного массива размерностью Byte,
                                                                  // состоящего из 19 элементов, для хранения значений
                                                                  //из ПЛК
        public static byte[] ThreeLinePB11Errors2 = new byte[19];
        public static byte[] ThreeLinePB11Errors3 = new byte[19];

        //Функция коннекта
        public static void connectTo()
        {
            
            fds.rfd = libnodave.openSocket(102, "192.168.0.1");
            fds.wfd = fds.rfd;
            di = new libnodave.daveInterface(fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
            res = di.initAdapter();
            dc = new libnodave.daveConnection(di, 0, 0, 2);
            res = dc.connectPLC();
            memoryRes1 = dc.readBytes(libnodave.daveDB, 13, 70, 19, ThreeLinePB11Errors1);
            memoryRes2 = dc.readBytes(libnodave.daveDB, 13, 110, 19, ThreeLinePB11Errors2);
            memoryRes3 = dc.readBytes(libnodave.daveDB, 13, 142, 13, ThreeLinePB11Errors3);

            dc.disconnectPLC();
            di.disconnectAdapter();
            libnodave.closePort(fds.rfd);
        }
    }
}
