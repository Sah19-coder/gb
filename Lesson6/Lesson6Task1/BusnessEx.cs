using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
 * Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса. 
 * В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill
 * */
namespace Lesson6Task1
{
    public class BusnessEx : Exception
    {
        private int _subCode = 0;
        public int ErrorCode
        {
            get 
            { 
                return _subCode;
            }
        set

            {
                _subCode = value;
            }
    }
}
