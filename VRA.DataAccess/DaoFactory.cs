using System;
using System.Collections.Generic;
using System.Text;

namespace VRA.DataAccess
{
    public class DaoFactory
    {
        public static ITeacherDao GetTeacherDao()
        {
            return new TeacherDao();
        }
    }
}
