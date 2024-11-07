using demo02.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo02.DAO;

namespace demo02.DAO
{
    public class tableDAO
    {
        private static tableDAO instance;

        public static tableDAO Instance
        {
            get { if (instance == null) instance = new tableDAO(); return tableDAO.instance;  }
            private set { tableDAO.instance = value;  }
        }

        private tableDAO() 
        {
            
        }

    
    }
}
